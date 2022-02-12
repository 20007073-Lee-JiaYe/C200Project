using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using C200_Official.Models;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using System.Data;
using Member = C200_Official.Models.Member;
using System.Text;
using System.Security.Cryptography;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace C200_Official.Controllers
{

    [Authorize(AuthenticationSchemes = "HealthyScheme")]
    public class MembersController : Controller
    {
        private readonly AppDbContext _context;
        private string searchString;

        public MembersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Members.ToListAsync
            //

            var members = from m in _context.Members
                          select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                members = members.Where(s => s.FirstName!.Contains(searchString));
            }

            return View(await members.ToListAsync());
        }

        // GET: Members/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }



        // GET: Register/Create{
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }


        // POST: Register/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,FirstName,LastName,Email,Password,Role,LastLogin")] Member member)
        {
            //if (ModelState.IsValid)
            //{
            //    member.Password = CalculateSha1(member.Password.ToString());

            //    _context.Add(member);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(member);
            if (!ModelState.IsValid)
            {
                ViewData["Message"] = "Invalid Input";
                ViewData["MsgType"] = "warning";
                return View("Create");
            }
            else
            {
                string insert =
                 @"INSERT INTO Member(Id, Username, FirstName, LastName, Email, Password, Role, LastLogin) VALUES
                 ('{0}', '{1}','{2}', '{3}', '{4}', HASHBYTES('SHA1', '{5}'), 'Member', '{6: YYYY-MM-dd HH:ss}')";
              
                if (DBUtl.ExecSQL(insert, member.Id, member.Username, member.FirstName, member.LastName, member.Email, member.Password, member.Role, member.LastLogin) == 1)
                {
                    ViewData["Message"] = "User Successfully Registered";
                    ViewData["MsgType"] = "success";
                }
                else
                {
                    ViewData["Message"] = "User not Registered!";
                    ViewData["MsgType"] = "warning";
                }
                return View("Create");
            }

        }


      

        // GET: Members/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit()
        {
            int id = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost()
        {
            int id = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            IFormCollection form = HttpContext.Request.Form;

            string username = form["Username"].ToString().Trim();
            string firstname = form["FirstName"].ToString().Trim();
            string lastname = form["LastName"].ToString().Trim();
            string email = form["Email"].ToString().Trim();

            if (ModelState.IsValid)
            {
                try
                {

                    //var hashedPw = CalculateSha1(member.Password.ToString());
                    //var hashedPw = CalculateSha1(member.Password.ToString());
                    string update =
                     @"UPDATE  Member SET  Username = '{1}' , FirstName= '{2}', 
        LastName= '{3}', Email = '{4}' WHERE Id = '{0}'";


                    if (DBUtl.ExecSQL(update, id, username,
                        firstname, lastname, email) == 1)
                    {
                        ViewData["Message"] = "User Successfully Registered";
                        ViewData["MsgType"] = "success";
                    }
                    else
                    {
                        ViewData["Message"] = "User not Registered!";
                        ViewData["MsgType"] = "warning";
                    }

                    //_context.Update(member);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }

        [AllowAnonymous]
        public IActionResult VerifyUserID(string userId)
        {
            string select = $"SELECT * FROM Member WHERE Userid='{userId}'";
            if (DBUtl.GetTable(select).Rows.Count > 0)
            {
                return Json($"[{userId}] already in use");
            }
            return Json(true);
        }



        // GET: Members/Edit/5
        [Authorize]
        public async Task<IActionResult> EditMem()
        {
            int id = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditMem(int id, 
            [Bind("Id,Username,FirstName,LastName,Email,Role,LastLogin")] Member member)
        {
            if (id != member.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    member.Password = member.Password;
                    _context.Update(member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var member = await _context.Members.FindAsync(id);
            _context.Members.Remove(member);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
            return _context.Members.Any(e => e.Id == id);
        }


        public IActionResult ExportToExcel()
        {
            DbSet<Member> dbs = _context.Members;
            //var model = dbs.Include(a => a.Category)
            // .Include(a => a.Member)
            // .ToList();

            List<Member> memList = dbs.ToList();

            var memListConverted = memList.Select(a => new
            {
                Username = a.Username,
                Email = a.Email
            }).ToExpandoList();
            //dynamic articleListConverted = articleList.ToExpandoList();

            List<String> memHeaders = new List<String>();
            memHeaders.Add("Username");
            memHeaders.Add("Email");

            string filePath = Path.Combine(Environment.CurrentDirectory,
           "wwwroot\\ExcelFiles\\ExcelSpreadsheet_Articles.xlsx");

            ExcelUtl.createExcelWithContent(filePath, memHeaders, memListConverted);

            return View();
        }

        ///////////////////////////////////////////////////////
        ///

        public IActionResult FromExcelInsertToDB()
        {
            DbSet<Member> dbs = _context.Members;
            string filename = Path.Combine(Environment.CurrentDirectory,
                "wwwroot\\ExcelUpload\\UploadMember.xlsx");

            using (SpreadsheetDocument spreadsheetDocument =
                SpreadsheetDocument.Open(filename, false))
            {
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                DocumentFormat.OpenXml.Spreadsheet.SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                List<string> memberDetails = new List<string>();

                foreach (Row r in sheetData.Elements<Row>())
                {
                    memberDetails.Clear();
                    Member newMem = new Member();

                    foreach (Cell c in r.Elements<Cell>())
                    {
                        if (c.DataType != null && c.DataType == CellValues.SharedString)
                        {
                            var stringId = Convert.ToInt32(c.InnerText);
                            memberDetails
                                .Add(workbookPart.SharedStringTablePart
                                .SharedStringTable.Elements<SharedStringItem>()
                                .ElementAt(stringId).InnerText);
                        }

                        else if (c.InnerText != null || c.InnerText != string.Empty)
                        {
                            memberDetails.Add(c.InnerText);
                        }
                    }

                    //memberDetails content 
                    //0 -> Username
                    //1 -> Firstname
                    //2 -> Lastname
                    //3 -> Email
                    //4 -> DOB
                    //newMem.MemId = Int32.Parse(articleDetails[2].ToString());
                    //Random rnd = new Random();
                    newMem.Username = memberDetails[0];
                    newMem.FirstName = memberDetails[1];
                    newMem.LastName = memberDetails[2];
                    newMem.Email = memberDetails[3];
                    //newMem.Birthdate = DateTime.Parse(memberDetails[4]);
                    string rawPassword = "password";
                    var hashedPw = CalculateSha1(rawPassword);
                    //byte[] bytes = Encoding.ASCII.GetBytes(hashedPw);
                    newMem.Password = hashedPw;
                    //Int32.Parse(rnd.Next(8));
                    newMem.Role = "Member";

                    dbs.Add(newMem);

                    //send email to each new member

                    string username = memberDetails[0];
                    string email = memberDetails[3];
                    string subject = "Your HealthYouAndMe Account has been created";
                    string message = "Thank you for joing the HealthyYouAndMe Family";

                    string template = @"Hi {0},
                                           <p>{1}</p>
                                           <p>Your password for your account is <b>{2}</b>.</p>";

                    string body = String.Format(template, username, message, rawPassword);

                    string result;
                    EmailUtl.SendEmail(email, subject, body, out result);

                    //end of email code
                }
                _context.SaveChanges();  //ensure the import of excel is executed
            }

            return View();
        }

        public IActionResult SendEmail()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult SendEmail(IFormCollection form)
        //{
        //    // Old Method of reading values from Forms
        //    string custname = form["CustName"].ToString().Trim();
        //    string email = form["Email"].ToString().Trim();
        //    string subject = form["Subject"].ToString().Trim();
        //    string message = form["Message"].ToString().Trim();

        //    string template = @"Hi {0},
        //                       <p>{1}</p>
        //                       <p>Your password for your account is <b>{2}</b>.</p>
        //                      Manager";
        //    string password = Guid.NewGuid().ToString().Substring(0, 12);
        //    string body = String.Format(template, custname, message, password);
        //    string result;
        //    if (EmailUtl.SendEmail(email, subject, body, out result))
        //    {
        //        ViewData["Message"] = "Email Successfully Sent";
        //        ViewData["MsgType"] = "success";
        //    }
        //    else
        //    {
        //        ViewData["Message"] = result;
        //        ViewData["MsgType"] = "warning";
        //    }

        //    return View();
        //}

        //private static string CalculateSha1(string text)
        //{
        //    var enc = Encoding.GetEncoding(65001); // utf-8 code
        // byte[] buffer = enc.GetBytes(text);

        //    var sha1 = System.Security.Cryptography.SHA1.Create();

        //    var hash = sha1.ComputeHash(buffer);

        //    return enc.GetString(hash);
        //}

        private static readonly Encoding Encoding1252 = Encoding.GetEncoding(1252);

        private static byte[] CalculateSha1(string text)
        {
            //var enc = Encoding.GetEncoding(0);

            //byte[] buffer = enc.GetBytes(text);
            //var sha1 = SHA1.Create();
            //var hash = BitConverter.ToString(sha1.ComputeHash(buffer)).Replace("-", "");
            //return hash;

            //var sha1 = System.Security.Cryptography.SHA1.Create();

            //var enc = Encoding.GetEncoding(0);
            //byte[] buffer = enc.GetBytes(text);
            //var hash = sha1.ComputeHash(buffer);

            byte[] bytes = Encoding1252.GetBytes(text);

            var sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(bytes);

            return hashBytes;

        }


    }
}
