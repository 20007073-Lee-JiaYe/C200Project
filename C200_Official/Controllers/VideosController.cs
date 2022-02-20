using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using C200_Official.Models;
using Microsoft.AspNetCore.Authorization;
using Rotativa.AspNetCore;
using System.Data;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace C200_Official.Controllers
{
    public class VideosController : Controller
    {
        private readonly AppDbContext _context;

        public VideosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Videos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Videos.Include(v => v.Category).Include(v => v.Member);
            return View(await appDbContext.ToListAsync());
        }

        public async Task<IActionResult> IndexMember() // an area for user to see the videos they posted 
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var appDbContext = _context.Videos
                                .Where(a => a.MemberId == userId)
                               .Include(a => a.Category)
                               .Include(a => a.Member)
                               .Include(a => a.VideoRatings);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Videos/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var video = await _context.Videos
                //for a video in the videos table i want to get the category record
                .Where(m => m.Id == id)
                .Include(a => a.Category)
                .Include(a => a.Member)
                .Include(a => a.VideoComments).ThenInclude(a => a.Member) //EDITION HERE
                .FirstOrDefaultAsync();

            if (video == null)
            {
                return NotFound();
            }

            int theRealUserID = 0;
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                theRealUserID = Int32.Parse(userId);
                int ratingbyMember = 0;
                VideoRating hasRating = _context.VideoRatings.Where(vr => vr.MemberId == theRealUserID && vr.VideoId == id).FirstOrDefault();

                if (hasRating != null)
                {
                    ratingbyMember = hasRating.Ratings;
                }

                ViewData["rm"] = ratingbyMember;  // to pass view from controller to videos.cshtml

                double RatingAverage = 0.0;

                VideoRating isThisVideoRated = _context.VideoRatings.Where(vr => vr.VideoId == id).FirstOrDefault(); //check if there are any records

                if (isThisVideoRated != null)
                {
                    RatingAverage = _context.VideoRatings.Where(vr => vr.VideoId == id).Average(vr => vr.Ratings); //calculate the average
                    ViewData["avg"] = RatingAverage;
                }
            }

            var videoWithCommentsAndMemberDetails = video; //clone of var video with category, member and video comments


            CommentsUtl commentsUtl = new CommentsUtl();
            video.VideoComments = commentsUtl.sortByLatestVideoComments(videoWithCommentsAndMemberDetails.VideoComments.ToList());

            return View(video);
        }

        // GET: Videos/Details/5
        public async Task<IActionResult> IndexMemberDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var video = await _context.Videos
                .Where(m => m.Id == id)
                .Include(v => v.Category)
                .Include(v => v.Member)
                .Include(v=> v.VideoComments).ThenInclude(v => v.Member)
                .FirstOrDefaultAsync();
            if (video == null)
            {
                return NotFound();
            }

            var videoWithCommentsAndMemberDetails = video; //clone of var video with category, member and video comments

            CommentsUtl commentsUtl = new CommentsUtl();
            video.VideoComments = commentsUtl.sortByLatestVideoComments(videoWithCommentsAndMemberDetails.VideoComments.ToList());

            return View(video);
        }

        public async Task<IActionResult> IndexVideoAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var video = await _context.Videos
                //for a video in the videos table i want to get the category record
                .Where(m => m.Id == id)
                .Include(a => a.Category)
                .Include(a => a.Member)
                .Include(a => a.VideoComments) //EDITION HERE
                .ThenInclude(a => a.Member)
                .FirstOrDefaultAsync();

            if (video == null)
            {
                return NotFound();
            }
            //display the member name by using the member ID that posted the comment, and match with member details ID, so to get his name 
            var videoWithCommentsAndMemberDetails = video; //clone of var video with category, memeber and video comments

            CommentsUtl commentsUtl = new CommentsUtl();
            video.VideoComments = commentsUtl.sortByLatestVideoComments(videoWithCommentsAndMemberDetails.VideoComments.ToList());
            return View(video);
        }

        [Authorize(Roles = "Member, Admin")]
        // GET: Videos/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username");
            ViewData["CurrentMemberID"] = new SelectList(_context.Members, User.FindFirst(ClaimTypes.NameIdentifier).Value);
            return View();
        }

        [Authorize(Roles = "Member, Admin")]
        // POST: Videos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Link,Description,Status,CategoryId")] Video video)
        {
            if (ModelState.IsValid)
            {
                IFormCollection form = HttpContext.Request.Form;
                string status = form["Status"].ToString().Trim();
                video.SubmittedOn = DateTime.Now;
                video.DatePublished = DateTime.Now;
                video.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

                _context.Add(video);
                await _context.SaveChangesAsync();

                TempData["Message"] = "Video link sucessfully uploaded.";
                TempData["MsgType"] = "success";
                return RedirectToAction("IndexMember"); // changed to INDEXMEMBER (ange edit)

            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", video.CategoryId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", video.MemberId);
            return View(video);
        }

        [Authorize(Roles = "Member, Admin")]
        // GET: Videos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var video = await _context.Videos.FindAsync(id);
            if (video == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", video.CategoryId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", video.MemberId);
            return View(video);
        }

        [Authorize(Roles = "Member, Admin")]
        // POST: Videos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Link,Description,CategoryId,MemberId")] Video video)
        {
            if (id != video.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    video.Status = "Pending";
                    video.SubmittedOn = DateTime.Now;
                    video.DatePublished = DateTime.Now;
                    video.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

                    _context.Update(video);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideoExists(video.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexMember));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", video.CategoryId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", video.MemberId);
            return View(video);
        }

        private bool VideoExists(int id)
        {
            return _context.Videos.Any(e => e.Id == id);
        }

        // POST: VideosComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult AddComment(int VideoID) //taken from the asp-asp-route-VideoID="@Model.Id" in videos details
        {
            string stringFullUrl = "";

            IFormCollection form = HttpContext.Request.Form;
            string comment = form["comment"].ToString();

            if (ValidUtl.CheckIfEmpty(comment))
            {
                TempData["Message"] = "Comment unsucessfully posted! Please enter something.";
                TempData["MsgType"] = "danger";
                stringFullUrl = "~/Videos/Details/" + VideoID.ToString();
                return Redirect(stringFullUrl);
            }
            else
            {
                VideoComment newComment = new VideoComment();

                newComment.Comments = comment;
                newComment.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                newComment.VideoId = VideoID;
                newComment.CommentDate = DateTime.Now;
                var mlUtl = new MLUtl();

                String predict = mlUtl.PredictOffensiveAngela(comment);

                if (predict.Equals("1"))
                {
                    newComment.Status = "Pending";

                    //mirror of actual of database, "object of the DB"
                    _context.Add(newComment);
                    _context.SaveChangesAsync(); //save to the REAL database 

                    TempData["Message"] = "Comment requires admin approval.";
                    TempData["MsgType"] = "warning";
                }
                else
                {
                    newComment.Status = "Published";

                    //mirror of actual of database, "object of the DB"
                    _context.Add(newComment);
                    _context.SaveChangesAsync(); //save to the REAL database 

                    TempData["Message"] = "Comment Sucessfully Posted!";
                    TempData["MsgType"] = "success";
                }

                stringFullUrl = "~/Videos/Details/" + VideoID.ToString();
                return Redirect(stringFullUrl);

            }

        }

        public IActionResult AddRating(int VideoID) //taken from the asp-asp-route-VideoID="@Model.Id" in videos details
        {
            string stringFullUrl = "";

            IFormCollection form = HttpContext.Request.Form;
            string rating = form["rating"].ToString();

            if (ValidUtl.CheckIfEmpty(rating))
            {
                TempData["Message"] = "Rating unsucessfully posted! Please enter something.";
                TempData["MsgType"] = "warning";
                stringFullUrl = "~/Videos/Details/" + VideoID.ToString();
                return Redirect(stringFullUrl);
            }
            else
            {
                VideoRating newRating = new VideoRating();

                newRating.Ratings = Int32.Parse(rating);
                newRating.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                newRating.VideoId = VideoID;
                // newComment.DatePublished = DateTime.Now;

                //mirror of actual of database, "object of the DB"
                _context.Add(newRating);
                _context.SaveChanges(); //save to the REAL database 

                TempData["Message"] = "Rating Sucessfully Posted!";
                TempData["MsgType"] = "success";

                stringFullUrl = "~/Videos/Details/" + VideoID.ToString();
                return Redirect(stringFullUrl);

            }


        }

        //USER ARCHIVE
        public IActionResult ArchiveVideoPost(int id)
        {

            DbSet<Video> dbs = _context.Videos;
            Video vid = dbs.Where(so => so.Id == id).FirstOrDefault();
            if (vid != null)
            {
                vid.Status = "ArchivedByUser";
                if (_context.SaveChanges() == 1)
                {
                    TempData["Msg"] = "Video Post being Archived!";
                    TempData["MsgType"] = "success";
                }
                else
                {
                    TempData["Msg"] = "Failed to archived!";
                    TempData["MsgType"] = "danger";
                }
            }
            else
            {
                TempData["Msg"] = "Video ID not found!";
                TempData["MsgType"] = "danger";
            }
            return RedirectToAction("IndexMember");
        }

        //USER UNARCHIVE 
        public IActionResult UnarchiveVideoPost(int id)
        {

            DbSet<Video> dbs = _context.Videos;
            Video vid = dbs.Where(so => so.Id == id).FirstOrDefault();
            UpdateStatusToPublish(vid);
            return RedirectToAction("IndexMember");
        }

        public IActionResult Delete(int id)
        {
            DbSet<Video> dbs = _context.Videos;

            Video ar = dbs.Where(so => so.Id == id).FirstOrDefault();

            if (ar != null)
            {
                var ans = _context.Videos.Include(x => x.VideoComments)
                    .Include(x => x.VideoRatings)
                    .First(x => x.Id == id);
                foreach (VideoComment item in ans.VideoComments)
                {
                    _context.VideoComments.Remove(item);
                }
                foreach (VideoRating item in ans.VideoRatings)
                {
                    _context.VideoRatings.Remove(item);
                }
                _context.Videos.Remove(ar);
                _context.Videos.Remove(ar);
                _context.SaveChanges();
                TempData["Message"] = "Deleted successfully";
                TempData["MsgType"] = "success";
            }
            else
            {
                TempData["Msg"] = "Video ID not found!";
                TempData["MsgType"] = "delete";
            }
            return RedirectToAction("IndexMember");
        }


        public IActionResult AdminDelete(int id)
        {
            DbSet<Video> dbs = _context.Videos;

            Video ar = dbs.Where(so => so.Id == id).FirstOrDefault();

            if (ar != null)
            {
                var ans = _context.Videos.Include(x => x.VideoComments)
                    .Include(x => x.VideoRatings)
                    .First(x => x.Id == id);
                foreach (VideoComment item in ans.VideoComments)
                {
                    _context.VideoComments.Remove(item);
                }
                foreach (VideoRating item in ans.VideoRatings)
                {
                    _context.VideoRatings.Remove(item);
                }
                _context.Videos.Remove(ar);
                _context.Videos.Remove(ar);
                _context.SaveChanges();
                TempData["Message"] = "Deleted successfully";
                TempData["MsgType"] = "success";
            }
            else
            {
                TempData["Msg"] = "Video ID not found!";
                TempData["MsgType"] = "delete";
            }
            return RedirectToAction("ApprovalOfVideos");
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApprovalOfVideos()
        {
            //who is currently login in as the current user, to let her see her own video post
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var appDbContext = _context.Videos
                                .Where(a => a.Status.Equals("Pending"))
                               .Include(a => a.Category)
                               .Include(a => a.Member);
            return View(await appDbContext.ToListAsync());
        }

        //ACTION approve
        [Authorize(Roles = "Admin")]
        public IActionResult AdminApproveVideos(int id)
        {

            DbSet<Video> dbs = _context.Videos;
            Video vid = dbs.Where(so => so.Id == id).FirstOrDefault();
            UpdateStatusToPublish(vid);
            TempData["Message"] = "Video post being approved.";
            TempData["MsgType"] = "success";
            return RedirectToAction("ApprovalOfVideos");
        }

        public void UpdateStatusToPublish(Video video)
        {
            string orginalStatus = video.Status;
            if (video != null)
            {
                video.Status = "Published";
                if (_context.SaveChanges() == 1)
                    if (orginalStatus.Equals("Pending"))
                    {
                        TempData["Msg"] = "Video published successfully.";
                        TempData["MsgType"] = "success";
                    }
                    else
                    {
                        TempData["Msg"] = "Video being unarchived.";
                        TempData["MsgType"] = "success";
                    }
                else
                    TempData["Msg"] = "Failed to unarchived Video!";
                TempData["MsgType"] = "danger";
            }
            else
            {
                TempData["Msg"] = "Video ID not found!";
                TempData["MsgType"] = "danger";
            }

        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PendingComments()
        {

            var appDbContext = _context.VideoComments.Include(q => q.Video).ThenInclude(q => q.Category).Include(q => q.Member);
            return View(await appDbContext.ToListAsync());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PendingCommentsDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var video = await _context.VideoComments
                .Include(q => q.Member)
                 .Include(q => q.Video)
                .ThenInclude(q => q.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (video == null)
            {
                return NotFound();
            }

            return View(video);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApproveComments(int id)
        {

            DbSet<VideoComment> dbs = _context.VideoComments;
            VideoComment vidComment = dbs.Where(so => so.Id == id)
                .Include(a => a.Member)
                .FirstOrDefault();
            if (vidComment != null)
            {
                vidComment.Status = "Published";

                if (_context.SaveChanges() == 1)
                {
                    TempData["Message"] = "Video comment published.";
                    TempData["MsgType"] = "success";
                    await SendGridUtl.SendEMail(vidComment.Member.Email, vidComment.Member.FirstName, vidComment.Comments, "approved");
                }

                else
                {
                    TempData["Message"] = "Failed to publish!";
                    TempData["MsgType"] = "danger";
                }

            }
            else
            {
                TempData["Message"] = "Comment ID not found!";
                TempData["MsgType"] = "danger";
            }
            return RedirectToAction("PendingComments");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RejectComments(int id)
        {

            DbSet<VideoComment> dbs = _context.VideoComments;
            VideoComment vidComment = dbs.Where(so => so.Id == id)
                .Include(a => a.Member)
                .FirstOrDefault();
            if (vidComment != null)
            {
                vidComment.Status = "Rejected";

                if (_context.SaveChanges() == 1)
                {
                    TempData["Message"] = "Video comment successfully rejected";
                    TempData["MsgType"] = "success";
                    await SendGridUtl.SendEMail(vidComment.Member.Email, vidComment.Member.FirstName, vidComment.Comments, "rejected");
                }

                else
                {
                    TempData["Message"] = "Failed to reject!";
                    TempData["MsgType"] = "danger";
                }

            }
            else
            {
                TempData["Message"] = "Comment ID not found!";
                TempData["MsgType"] = "danger";
            }
            return RedirectToAction("PendingComments");
        }

    }
}
