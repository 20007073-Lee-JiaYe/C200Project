using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using C200_Official.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace C200_Official.Controllers
{
    [Authorize(AuthenticationSchemes = "HealthyScheme")]
    public class QuestionsController : Controller


    {
        private readonly AppDbContext _context;

        public QuestionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Questions
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Questions.Include(q => q.Category).Include(q => q.Member);

            return View(await appDbContext.ToListAsync());
        }

        // GET: Questions/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .Include(q => q.Category)
                .Include(q => q.Member)
                .Include(q => q.Answers).ThenInclude(q => q.Member) // INCLUDE THE ANS SO CAN USE THIS DATA
                .Where(q => q.Status.Equals("Published"))
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            int theRealUserID = 0;
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                theRealUserID = Int32.Parse(userId);
                int ratingbyMember = 0;
                QuestionRating hasRating = _context.QuestionRatings.Where(ar => ar.MemberId == theRealUserID && ar.QuestionId == id).FirstOrDefault();

                if (hasRating != null)
                {
                    ratingbyMember = hasRating.Ratings;
                }

                ViewData["rm"] = ratingbyMember;  // to pass view from controller to articles.cshtml

                double RatingAverage = 0.0;

                QuestionRating isThisArticleRated = _context.QuestionRatings.Where(ar => ar.QuestionId == id).FirstOrDefault(); //check if there are any records

                if (isThisArticleRated != null)
                {
                    RatingAverage = _context.QuestionRatings.Where(ar => ar.QuestionId == id).Average(ar => ar.Ratings); //calculate the average
                    ViewData["avg"] = RatingAverage;
                }
            }
            var questionWithAnswersAndMemberDeatails = question;

            CommentsUtl commentsUtl = new CommentsUtl();
            question.Answers = commentsUtl.sortByLatestComments(questionWithAnswersAndMemberDeatails.Answers.ToList(), true);

            return View(question);
        }


        // GET: Questions/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username");
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MemberId,DateCreated,Content,CategoryId,Status")] Question question)
        {
            question.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (ModelState.IsValid)
            {
                question.DateCreated = DateTime.Now;
                question.Status = "Published";

                _context.Add(question);
                await _context.SaveChangesAsync();

                TempData["Message"] = "Question sucessfully posted";
                TempData["MsgType"] = "success";
                return RedirectToAction("Index");

            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", question.CategoryId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", question.MemberId);
            return View(question);

        }

        // GET: Questions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", question.CategoryId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", question.MemberId);
            return View(question);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MemberId,DateCreated,Content,CategoryId,Status")] Question question)
        {
            if (id != question.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                question.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                question.DateCreated = DateTime.Now;
                question.Status = "Published";


                try
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionExists(question.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("MemQns");
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", question.CategoryId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", question.MemberId);
            return View(question);
        }

        public async Task<IActionResult> MemQns() // an area for user to see the qns they posted 
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var appDbContext = _context.Questions
                                .Where(a => a.MemberId == userId)
                               .Include(a => a.Category)
                               .Include(a => a.Member);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Questions/Details/5
        [Authorize]
        public async Task<IActionResult> MemQnDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .Include(q => q.Category)
                .Include(q => q.Member)
                .Include(q => q.Answers) // INCLUDE THE ANS SO CAN USE THIS DATA
                .ThenInclude(q => q.Member)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            var questionWithAnswersAndMemberDetails = question;
            CommentsUtl commentsUtl = new CommentsUtl();
            question.Answers = commentsUtl.sortByLatestComments(questionWithAnswersAndMemberDetails.Answers.ToList(), true);

            return View(question);
        }

        public async Task<IActionResult> UserArchivedQn() // an area for user to see the qns they archive 
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var appDbContext = _context.Questions
                                .Where(a => a.MemberId == userId)
                               .Include(a => a.Category)
                               .Include(a => a.Member);
            return View(await appDbContext.ToListAsync());
        }

        //USER ARCHIVE
        public IActionResult ArchiveQn(int id)
        {

            DbSet<Question> dbs = _context.Questions;
            Question qn = dbs.Where(so => so.Id == id).FirstOrDefault();
            if (qn != null)
            {
                qn.Status = "ArchivedByUser";
                if (_context.SaveChanges() == 1)
                {
                    TempData["Message"] = "Question ID Archived!";
                    TempData["MsgType"] = "sucessful";
                }
                else
                {
                    TempData["Message"] = "Failed to archived!";
                    TempData["MsgType"] = "warning";
                }

            }
            else
            {
                TempData["Message"] = "Question ID not found!";
                TempData["MsgType"] = "warning";
            }
            return RedirectToAction("MemQns");
        }

        //USER UNARCHIVE

        public IActionResult UnarchiveQn(int id)
        {
            DbSet<Question> dbs = _context.Questions;
            Question qn = dbs.Where(so => so.Id == id).FirstOrDefault();
            if (qn != null)
            {
                qn.Status = "Published";
                if (_context.SaveChanges() == 1)
                {
                    TempData["Message"] = "Question ID is shown on public!";
                    TempData["MsgType"] = "sucessful";
                }

                else
                {
                    TempData["Message"] = "Failed to unarchived!";
                    TempData["MsgType"] = "warning";

                }

            }
            else
            {
                TempData["Message"] = "Question ID not found!";
                TempData["MsgType"] = "warning";
            }
            return RedirectToAction("MemQns");
        }

        //USER DELETE:
        public IActionResult Delete(int id)
        {
            DbSet<Question> dbs = _context.Questions;

            Question qn = dbs.Where(so => so.Id == id).FirstOrDefault();

            if (qn != null)
            {
                var ques = _context.Questions.Include(x => x.Answers).Include(x=> x.QuestionRatings).First(x => x.Id == id);
                foreach (Answer item in ques.Answers)
                {
                    _context.Answers.Remove(item);
                }
                foreach (QuestionRating item in ques.QuestionRatings)
                {
                    _context.QuestionRatings.Remove(item);
                }
                _context.Questions.Remove(ques);
                _context.SaveChanges();
                /*
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
                 */






                TempData["Message"] = "Deleted successfully";
                TempData["MsgType"] = "success";

            }
            else
            {
                TempData["Message"] = "Question ID not found!";
                TempData["MsgType"] = "delete";

            }
            return RedirectToAction("MemQns");
        }
        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.Id == id);
        }

        public IActionResult AddAnswer(int QuestionID) //taken from the asp-asp-route-ArticleID="@Model.Id" in articles details
        {
            string stringFullUrl = "";

            IFormCollection form = HttpContext.Request.Form;
            string description = form["description"].ToString();

            if (ValidUtl.CheckIfEmpty(description))
            {
                TempData["Message"] = "Comment unsucessfully posted! Please enter something.";
                TempData["MsgType"] = "danger";
                stringFullUrl = "~/Questions/Details/" + QuestionID.ToString();
                return Redirect(stringFullUrl);
            }
            else
            {
                Answer newAnswer = new Answer();

                newAnswer.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                newAnswer.AnsweredDate = DateTime.Now;
                newAnswer.Description = description;
                newAnswer.QuestionId = QuestionID;
                var mlUtl = new MLUtl();

                String predict = mlUtl.PredictEmotions(description);
             

                if (predict.Equals("Negative"))
                {
                    newAnswer.Status = "Pending";

                    //mirror of actual of database, "object of the DB"
                    _context.Add(newAnswer);
                    _context.SaveChangesAsync(); //save to the REAL database 

                    TempData["Message"] = "Comment requires admin approval.";
                    TempData["MsgType"] = "warning";
                }
                else
                {
                    newAnswer.Status = "Published";

                    _context.Add(newAnswer);
                    _context.SaveChangesAsync(); 

                    TempData["Message"] = "Comment Sucessfully Posted!";
                    TempData["MsgType"] = "success";
                }

               
                stringFullUrl = "~/Questions/Details/" + QuestionID.ToString();

                return Redirect(stringFullUrl);

            }
        }

        public IActionResult AddRating(int QuestionID) //taken from the asp-asp-route-ArticleID="@Model.Id" in articles details
        {
            string stringFullUrl = "";

            IFormCollection form = HttpContext.Request.Form;
            string rating = form["rating"].ToString();

            if (ValidUtl.CheckIfEmpty(rating))
            {
                TempData["Message"] = "Rating unsucessful. Please select a value.";
                TempData["MsgType"] = "warning";
                stringFullUrl = "~/Questions/Details/" + QuestionID.ToString();
                return Redirect(stringFullUrl);
            }
            else
            {
                QuestionRating newRating = new QuestionRating();

                newRating.Ratings = Int32.Parse(rating);
                newRating.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                newRating.QuestionId = QuestionID;

                //mirror of actual of database, "object of the DB"
                _context.Add(newRating);
                _context.SaveChanges(); //save to the REAL database 

                TempData["Message"] = "Rating Sucessfully Posted!";
                TempData["MsgType"] = "success";

                stringFullUrl = "~/Questions/Details/" + QuestionID.ToString();
                return Redirect(stringFullUrl);


            }
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PendingAnswer()
        {

            var appDbContext = _context.Answers.Include(q => q.Question).ThenInclude(q => q.Category).Include(q => q.Member);
            return View(await appDbContext.ToListAsync());
        }
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> PendingAnsDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answers
                .Include(q => q.Member)
                .Include(q => q.Question) // INCLUDE THE ANS SO CAN USE THIS DATA
                .ThenInclude(q => q.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }


        // Allows Admins to reject answers which are pending for review
        [Authorize(Roles = "Admin")]
        //[HttpPost]
        public async Task<IActionResult> ApproveAns(int id)
        {

            DbSet<Answer> dbs = _context.Answers;
            Answer ans = dbs.Where(so => so.Id == id)
                .Include(a => a.Member)
                .FirstOrDefault();
            if (ans != null)
            {
                ans.Status = "Published";

                if (_context.SaveChanges() == 1)
                {
                    TempData["Message"] = "Answer published.";
                    TempData["MsgType"] = "success";
                    await SendGridUtl.SendEMail(ans.Member.Email, ans.Member.FirstName, ans.Description, "approved");
                }

                else
                {
                    TempData["Message"] = "Failed to publish!";
                    TempData["MsgType"] = "warning";
                }

            }
            else
            {
                TempData["Message"] = "Answer ID not found!";
            }
            return RedirectToAction("PendingAnswer");
        }

        // Allows Admins to reject answers which are pending for review
        [Authorize(Roles = "Admin")]
        //[HttpPost]
        public async Task<IActionResult> RejectAns(int id)
        {

            DbSet<Answer> dbs = _context.Answers;
            Answer ans = dbs.Where(so => so.Id == id).Include(a => a.Member).FirstOrDefault();
            if (ans != null)
            {
                ans.Status = "Rejected";

                if (_context.SaveChanges() == 1)
                {
                    TempData["Message"] = "Answer rejected.";
                    TempData["MsgType"] = "success";
                    await SendGridUtl.SendEMail(ans.Member.Email, ans.Member.FirstName, ans.Description, "rejected");
                }

                else
                {
                    TempData["Message"] = "Failed to reject!";
                    TempData["MsgType"] = "warning";
                }

            }
            else
            {
                TempData["Message"] = "Answer ID not found!";
            }
            return RedirectToAction("PendingAnswer");
        }

    }

}
