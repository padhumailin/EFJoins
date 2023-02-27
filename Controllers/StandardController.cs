using EFJoins.Data;
using EFJoins.DTO;
using EFJoins.Enity;
using Microsoft.AspNetCore.Mvc;

namespace EFJoins.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StandardController : ControllerBase
    {

        readonly DBSet dbModel;

        private readonly ILogger<StandardController> _logger;

        public StandardController(ILogger<StandardController> logger, DBSet dbModel)
        {
            _logger = logger;
            this.dbModel = dbModel;
        }

        [HttpGet(Name = "GetStandard")]
        public async Task<IActionResult> GetStandard()
        {

            #region Left_Join
            // This LINQ generates left join but the expected is to be inner join

            var data = (from sdd in dbModel.Standard
                        select new StandardDTO
                        {
                            StandardID = sdd.StandardID,
                            StandardName = sdd.StandardName,
                            StandardDescription = sdd.StandardDescription,
                            Students = (from std in dbModel.Student
                                        where std.StandardID == sdd.StandardID
                                        select new StudentDTO
                                        {
                                            StudentID = std.StudentID,
                                            StudentName = std.StudentName,
                                            StudentRollID = std.StudentRollID,
                                            StudentLocation = std.StudentLocation,
                                            StandardID = std.StandardID,
                                        }).ToList()

                        });

            #endregion Left_Join


            //#region Inner_Join
            //// This LINQ generates inner join when DTO do not have nested collection 
            
            //var data = (from sdd in dbModel.Standard
            //            join std in dbModel.Student
            //                on sdd.StandardID equals std.StandardID
            //            select new StandardStudentDTO
            //            {
            //                StandardID = sdd.StandardID,
            //                StandardName = sdd.StandardName,
            //                StandardDescription = sdd.StandardDescription,
            //                StudentID = std.StudentID,
            //                StudentName = std.StudentName,
            //                StudentRollID = std.StudentRollID,
            //                StudentLocation = std.StudentLocation,
                           

            //            });

            //#endregion Inner_Join

            return Ok(data.Take(20));
        }
    }
}