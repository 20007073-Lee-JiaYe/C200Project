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
    [Authorize(AuthenticationSchemes = "HealthyScheme")]
    public class ArticlesController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env;

        public ArticlesController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _env = environment;
        }



        // GET: Articles
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {                                       //NICOLE
            var appDbContext = _context.Articles.Where(a => a.Status.Equals("Published"))
                                                    .Include(a => a.Category)
                                                 .Include(a => a.Member);

            return View(await appDbContext.ToListAsync());


        }

        public async Task<IActionResult> IndexMember() // an area for user to see the articles they posted 
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var appDbContext = _context.Articles
                                .Where(a => a.MemberId == userId)
                               .Include(a => a.Category)
                               .Include(a => a.Member)
                               .Include(a => a.ArticleRatings);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Articles/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                //for a article in the articles table i want to get the category record
                .Where(m => m.Id == id)
                .Include(a => a.Category)
                .Include(a => a.Member)
                .Include(a => a.ArticleComments).ThenInclude(a => a.Member) //EDITION HERE
                .FirstOrDefaultAsync();

            if (article == null)
            {
                return NotFound();
            }

            int theRealUserID = 0;
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                theRealUserID = Int32.Parse(userId);
                int ratingbyMember = 0;
                ArticleRating hasRating = _context.ArticleRatings.Where(ar => ar.MemberId == theRealUserID && ar.ArticleId == id).FirstOrDefault();

                if (hasRating != null)
                {
                    ratingbyMember = hasRating.Ratings;
                }

                ViewData["rm"] = ratingbyMember;  // to pass view from controller to articles.cshtml

                double RatingAverage = 0.0;

                ArticleRating isThisArticleRated = _context.ArticleRatings.Where(ar => ar.ArticleId == id).FirstOrDefault(); //check if there are any records

                if (isThisArticleRated != null)
                {
                    RatingAverage = _context.ArticleRatings.Where(ar => ar.ArticleId == id).Average(ar => ar.Ratings); //calculate the average
                    ViewData["avg"] = RatingAverage;
                }
            }

            //var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            //int ratingbyMember = 0;
            //ArticleRating hasRating = _context.ArticleRatings.Where(ar => ar.MemberId == userId && ar.ArticleId == id).FirstOrDefault();

            //if (hasRating != null)
            //{
            //    ratingbyMember = hasRating.Ratings;
            //}

            //ViewData["rm"] = ratingbyMember;  // to pass view from controller to articles.cshtml

            //double RatingAverage = 0.0;

            //ArticleRating isThisArticleRated = _context.ArticleRatings.Where(ar => ar.ArticleId == id).FirstOrDefault(); //check if there are any records

            //if (isThisArticleRated != null)
            //{
            //    RatingAverage = _context.ArticleRatings.Where(ar => ar.ArticleId == id).Average(ar => ar.Ratings); //calculate the average
            //    ViewData["avg"] = RatingAverage;
            //}

            //else
            //{
            //    TempData["Message"] = "This article has not been rated!";
            //    TempData["MsgType"] = "warning";
            //}

            //display the member name by using the member ID that posted the comment, and match with member details ID, so to get his name 
            var articleWithCommentsAndMemberDetails = article; //clone of var article with category, memeber and article comments

            CommentsUtl commentsUtl = new CommentsUtl();
            article.ArticleComments = commentsUtl.sortByLatestComments(articleWithCommentsAndMemberDetails.ArticleComments.ToList());
            return View(article);
        }

        // GET: Articles/Details/5
        [Authorize]
        public async Task<IActionResult> IndexMemberDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                //for a article in the articles table i want to get the category record
                .Where(m => m.Id == id)
                .Include(a => a.Category)
                .Include(a => a.Member)
                .Include(a => a.ArticleComments) //EDITION HERE
                .ThenInclude(a => a.Member)
                .FirstOrDefaultAsync();

            if (article == null)
            {
                return NotFound();
            }
            //display the member name by using the member ID that posted the comment, and match with member details ID, so to get his name 
            var articleWithCommentsAndMemberDetails = article; //clone of var article with category, memeber and article comments

            CommentsUtl commentsUtl = new CommentsUtl();
            article.ArticleComments = commentsUtl.sortByLatestComments(articleWithCommentsAndMemberDetails.ArticleComments.ToList());
            return View(article);
        }

        public async Task<IActionResult> IndexArticleAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                //for a article in the articles table i want to get the category record
                .Where(m => m.Id == id)
                .Include(a => a.Category)
                .Include(a => a.Member)
                .Include(a => a.ArticleComments) //EDITION HERE
                .ThenInclude(a => a.Member)
                .FirstOrDefaultAsync();

            if (article == null)
            {
                return NotFound();
            }
            //display the member name by using the member ID that posted the comment, and match with member details ID, so to get his name 
            var articleWithCommentsAndMemberDetails = article; //clone of var article with category, memeber and article comments

            CommentsUtl commentsUtl = new CommentsUtl();
            article.ArticleComments = commentsUtl.sortByLatestComments(articleWithCommentsAndMemberDetails.ArticleComments.ToList());
            return View(article);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username");
            ViewData["CurrentMemID"] = new SelectList(_context.Members, User.FindFirst(ClaimTypes.NameIdentifier).Value);
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id," +
            "Title,Content,SubmittedOn,PublishedOn,AiFlag,CategoryId,Picture")] Article article, IFormFile Photo)
        {
            //EDITED -> TAKE IN PENDING BUT STORE PE IN DB
            if (ModelState.IsValid)
            {
                IFormCollection form = HttpContext.Request.Form;
                string content = form["Content"].ToString().Trim();
                article.PublishedOn = DateTime.Now;
                article.SubmittedOn = DateTime.Now;
                // Nicole AI codes place here
                article.AiFlag = "No";
                article.Status = "Published";
                string fname = "";

                // Upload photo
                if (Photo != null)
                {
                    fname = DoPhotoUpload(Photo);
                }

                article.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                article.Picture = fname;

                var mlUtl = new MLUtl();
                String predict = mlUtl.PredictCategoryNicole(content);

                //MLNicole to check for non - health articles
                //if (predict.Equals("business") || predict.Equals("tech") || predict.Equals("politics") || predict.Equals("sport") || predict.Equals("entertainment"))
                //{
                //    article.AiFlag = "Yes";
                //    article.Status = "Pending";
                //    _context.Add(article);
                //    await _context.SaveChangesAsync();

                //    TempData["Message"] = "Article is not of health related type.";
                //    TempData["MsgType"] = "warning";
                //    return RedirectToAction("Index");
                //}
                //else
                //{
                //    article.AiFlag = "No";
                //    _context.Add(article);
                //    await _context.SaveChangesAsync();

                //    TempData["Message"] = "Article sucessfully posted.";
                //    TempData["MsgType"] = "success";
                //    return RedirectToAction("Index");
                //}

                //JANNICE
                article.AiFlag = "No";
                _context.Add(article);
                await _context.SaveChangesAsync();

                TempData["Message"] = "Article sucessfully posted.";
                TempData["MsgType"] = "success";
                return RedirectToAction("Index");

            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", article.CategoryId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", article.MemberId);
            return View(article);
        }


        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", article.CategoryId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", article.MemberId);
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,
            [Bind("Id,Title,Content,Status,SubmittedOn,PublishedOn,AiFlag,CategoryId,Picture")] Article article, IFormFile Photo)
        {
            if (id != article.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                IFormCollection form = HttpContext.Request.Form;

                string tickpic = form["chkpic"].ToString().Trim();

                article.PublishedOn = DateTime.Now;
                article.SubmittedOn = DateTime.Now;
                string fname = "";
                article.AiFlag = "No";

                if (Photo != null)
                {
                    fname = DoPhotoUpload(Photo);
                    article.Picture = fname;
                }
                article.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Description", article.CategoryId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", article.MemberId);
            return View(article);
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }

        public IActionResult PrintArticlesByRating()
        {
            DbSet<Article> dbs = _context.Articles;
            var model = dbs.Include(a => a.Category)
                           .Include(a => a.Member)
                           .Include(a => a.ArticleRatings)
                                .ToList();

            if (model != null)
                return new ViewAsPdf(model) //render the model to a pdf format
                {
                    PageSize = Rotativa.AspNetCore.Options.Size.B5,
                    PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape
                };
            else
            {
                TempData["Msg"] = "Error occured";
                return RedirectToAction("Index");
            }
        }

        public IActionResult PrintArticlesByMember()
        {
            DbSet<Article> dbs = _context.Articles;

            List<Article> ArticleList = dbs.Include(a => a.Member)
                                            .Include(a => a.Category)
                                            .ToList();

            var model = ArticleList.GroupBy(us => new { us.Member.Username, us.Category.Name })
            .Select(g => new
            {
                //MemberId = g.Key.MemberId,
                MemberName = g.Key.Username,
                //CategoryId = g.Key.CategoryId, //grp SOI student, the key is diploma , key-> has sub keys 
                CatName = g.Key.Name,
                NumberOfArticles = g.Count()
            }).OrderByDescending(g => g.NumberOfArticles)
            .ToExpandoList();

            ViewData["members"] = _context.Members.ToList<Member>();

            if (model != null)
                return new ViewAsPdf(model)
                {
                    PageSize = Rotativa.AspNetCore.Options.Size.B5,
                    PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape
                };
            else
            {
                TempData["Msg"] = "Error occured";
                return RedirectToAction("Index");
            }
        }

        // POST: ArticleComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult AddComment(int ArticleID, string ViewName) //taken from the asp-asp-route-ArticleID="@Model.Id" in articles details
        {
            string stringFullUrl = "";

            IFormCollection form = HttpContext.Request.Form;
            string comment = form["comment"].ToString();

            if (ValidUtl.CheckIfEmpty(comment))
            {
                TempData["Message"] = "Comment unsucessfully posted! Please enter something.";
                TempData["MsgType"] = "danger";
                stringFullUrl = "~/Articles/" + ViewName + "/" + ArticleID.ToString();
                return Redirect(stringFullUrl);
            }
            else
            {
                ArticleComment newComment = new ArticleComment();

                newComment.Content = comment;
                newComment.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                newComment.ArticleId = ArticleID;
                newComment.DatePublished = DateTime.Now;
                var mlUtl = new MLUtl();

                string predictOffensive = mlUtl.PredictOffensiveAngela(comment);

                if (predictOffensive.Equals("1"))
                {
                    newComment.Status = "Pending";
                    _context.Add(newComment);
                    _context.SaveChangesAsync();

                    TempData["Message"] = "Comment requires admin approval.";
                    TempData["MsgType"] = "warning";
                }
                else
                {
                    newComment.Status = "Published";
                    _context.Add(newComment);
                    _context.SaveChangesAsync();

                    TempData["Message"] = "Comment Sucessfully Posted!";
                    TempData["MsgType"] = "success";
                }

                stringFullUrl = "~/Articles/" + ViewName + "/" + ArticleID.ToString();
                return Redirect(stringFullUrl);

            }

        }

        public IActionResult AddRating(int ArticleID) //taken from the asp-asp-route-ArticleID="@Model.Id" in articles details
        {
            string stringFullUrl = "";

            IFormCollection form = HttpContext.Request.Form;
            string rating = form["rating"].ToString();

            if (ValidUtl.CheckIfEmpty(rating))
            {
                TempData["Message"] = "Rating unsucessful. Please select a value.";
                TempData["MsgType"] = "warning";
                stringFullUrl = "~/Articles/Details/" + ArticleID.ToString();
                return Redirect(stringFullUrl);
            }
            else
            {
                ArticleRating newRating = new ArticleRating();

                newRating.Ratings = Int32.Parse(rating);
                newRating.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                newRating.ArticleId = ArticleID;
                // newComment.DatePublished = DateTime.Now;

                //mirror of actual of database, "object of the DB"
                _context.Add(newRating);
                _context.SaveChanges(); //save to the REAL database 

                TempData["Message"] = "Rating Sucessfully Posted!";
                TempData["MsgType"] = "success";

                stringFullUrl = "~/Articles/Details/" + ArticleID.ToString();
                return Redirect(stringFullUrl);

            }


        }

        private string DoPhotoUpload(IFormFile photo)
        {
            string fext = Path.GetExtension(photo.FileName);
            string uname = Guid.NewGuid().ToString();
            string fname = uname + fext;
            string fullpath = Path.Combine(_env.WebRootPath, "pictures\\" + fname);
            FileStream fs = new FileStream(fullpath, FileMode.Create);
            photo.CopyTo(fs);
            fs.Close();
            return fname;
        }


        //USER ARCHIVE
        public IActionResult ArchiveArticle(int id)
        {

            DbSet<Article> dbs = _context.Articles;
            Article ar = dbs.Where(so => so.Id == id).FirstOrDefault();
            if (ar != null)
            {
                ar.Status = "ArchivedByUser";
                if (_context.SaveChanges() == 1)
                    TempData["Msg"] = "Article ID Archived!";
                else
                    TempData["Msg"] = "Failed to archived!";
            }
            else
            {
                TempData["Msg"] = "Article ID not found!";
            }
            return RedirectToAction("IndexMember");
        }

        //USER UNARCHIVE 
        public IActionResult UnarchiveArticle(int id)
        {

            DbSet<Article> dbs = _context.Articles;
            Article ar = dbs.Where(so => so.Id == id).FirstOrDefault();
            UpdateStatusToPublish(ar);
            return RedirectToAction("IndexMember");
        }

        public IActionResult Delete(int id)
        {
            DbSet<Article> dbs = _context.Articles;

            Article ar = dbs.Where(so => so.Id == id).FirstOrDefault();

            if (ar != null)
            {
                var ans = _context.Articles.Include(x => x.ArticleComments)
                    .Include(x => x.ArticleRatings)
                    .First(x => x.Id == id);
                foreach (ArticleComment item in ans.ArticleComments)
                {
                    _context.ArticleComments.Remove(item);
                }
                foreach (ArticleRating item in ans.ArticleRatings)
                {
                    _context.ArticleRatings.Remove(item);
                }
                _context.Articles.Remove(ar);
                _context.Articles.Remove(ar);
                _context.SaveChanges();
                TempData["Message"] = "Deleted successfully";
                TempData["MsgType"] = "success";
            }
            else
            {
                TempData["Msg"] = "Article ID not found!";
                TempData["MsgType"] = "delete";
            }
            return RedirectToAction("IndexMember");
        }


        public IActionResult AdminDelete(int id)
        {
            DbSet<Article> dbs = _context.Articles;

            Article ar = dbs.Where(so => so.Id == id).FirstOrDefault();

            if (ar != null)
            {
                var ans = _context.Articles.Include(x => x.ArticleComments)
                    .Include(x => x.ArticleRatings)
                    .First(x => x.Id == id);
                foreach (ArticleComment item in ans.ArticleComments)
                {
                    _context.ArticleComments.Remove(item);
                }
                foreach (ArticleRating item in ans.ArticleRatings)
                {
                    _context.ArticleRatings.Remove(item);
                }
                _context.Articles.Remove(ar);
                _context.SaveChanges();
                TempData["Message"] = "Deleted successfully";
                TempData["MsgType"] = "success";
            }
            else
            {
                TempData["Msg"] = "Article ID not found!";
            }
            return RedirectToAction("ApprovalOfArticles");
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApprovalOfArticles()
        {
            //who is currently login in as the current user, to let her see her own article
            //var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var appDbContext = _context.Articles
                                .Where(a => a.Status.Equals("Pending"))
                               .Include(a => a.Category)
                               .Include(a => a.Member);
            return View(await appDbContext.ToListAsync());
        }

        //ACTION approve
        [Authorize(Roles = "Admin")]
        public IActionResult AdminApproveArticles(int id)
        {

            DbSet<Article> dbs = _context.Articles;
            Article ar = dbs.Where(so => so.Id == id).FirstOrDefault();
            UpdateStatusToPublish(ar);
            TempData["MsgType"] = "success";
            TempData["Message"] = "Article approved";
            return RedirectToAction("ApprovalOfArticles");
        }

        //centrailize to update status to published
        public void UpdateStatusToPublish(Article article)
        {
            string orginalStatus = article.Status;
            if (article != null)
            {
                article.Status = "Published";
                if (_context.SaveChanges() == 1)
                    if (orginalStatus.Equals("Pending"))
                    {
                        TempData["Msg"] = "Article ID is published.";
                    }
                    else
                    {
                        TempData["Msg"] = "Article unarchived.";
                    }
                else
                    TempData["Msg"] = "Failed to unarchived!";
            }
            else
            {
                TempData["Msg"] = "Article ID not found!";
            }
        }

        //return view of a list of comments
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PendingComments()
        {

            var appDbContext = _context.ArticleComments.Include(q => q.Article).ThenInclude(q => q.Category).Include(q => q.Member);
            return View(await appDbContext.ToListAsync());
        }

        //return view of pending comments details
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PendingCommentsDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var article = await _context.ArticleComments
                .Include(q => q.Member)
                 .Include(q => q.Article)
                .ThenInclude(q => q.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }


        // ADMIN APPROVE COMMENTS OF APPROVE OR REJECT TYPE then sent email to the user of their comment status
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApproveComments(int id)
        {

            DbSet<ArticleComment> dbs = _context.ArticleComments;
            ArticleComment ans = dbs.Where(so => so.Id == id)
                .Include(a => a.Member)
                .FirstOrDefault();
            if (ans != null)
            {
                ans.Status = "Published";

                if (_context.SaveChanges() == 1)
                {
                    TempData["Message"] = "Answer published.";
                    TempData["MsgType"] = "success";
                    await SendGridUtl.SendEMail(ans.Member.Email, ans.Member.FirstName, ans.Content, "approved");
                }

                else
                {
                    TempData["Message"] = "Failed to publish!";
                    TempData["MsgType"] = "warning";
                }

            }
            else
            {
                TempData["Message"] = "Comment ID not found!";
            }
            return RedirectToAction("PendingComments");
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RejectComments(int id)
        {

            DbSet<ArticleComment> dbs = _context.ArticleComments;
            ArticleComment ans = dbs.Where(so => so.Id == id)
                .Include(a => a.Member)
                .FirstOrDefault();
            if (ans != null)
            {
                ans.Status = "Rejected";

                if (_context.SaveChanges() == 1)
                {
                    TempData["Message"] = "Answer successfully rejected";
                    TempData["MsgType"] = "success";
                    await SendGridUtl.SendEMail(ans.Member.Email, ans.Member.FirstName, ans.Content, "rejected");
                }

                else
                {
                    TempData["Message"] = "Failed to reject!";
                    TempData["MsgType"] = "warning";
                }

            }
            else
            {
                TempData["Message"] = "Comment ID not found!";
            }
            return RedirectToAction("PendingComments");
        }




    }
}
