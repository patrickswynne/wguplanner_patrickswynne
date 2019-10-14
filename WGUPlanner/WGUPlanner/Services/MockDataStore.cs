//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using WGUPlanner.Models;

//namespace WGUPlanner.Services
//{
//    class MockDataStore : IDataStore
//    {
//        readonly List<Planner> terms;

//        public MockDataStore()
//        {
//            terms = new List<Planner>();

//        #region Term Methods **
//        public async Task<bool> AddTermAsync(Planner term)
//        {
//            terms.Add(term);

//            return await Task.FromResult(true);
//        }

//        public async Task<bool> UpdateTermAsync(Planner term)
//        {
//            var oldTerm = terms.Where((Planner arg) => arg.TermTitle == term.TermTitle).FirstOrDefault();
//            terms.Remove(oldTerm);
//            terms.Add(term);

//            return await Task.FromResult(true);
//        }

//        public async Task<bool> DeleteTermAsync(string TermTitle)
//        {
//            var oldTerm = terms.Where((Planner arg) => arg.TermTitle == TermTitle).FirstOrDefault();
//            terms.Remove(oldTerm);

//            return await Task.FromResult(true);
//        }

//        public async Task<Planner> GetTermAsync(string TermTitle)
//        {
//            return await Task.FromResult(terms.FirstOrDefault(s => s.TermTitle == TermTitle));
//        }

//        public async Task<IEnumerable<Planner>> GetTermAsync(bool forceRefresh = false)
//        {
//            return await Task.FromResult(terms);
//        }
//        #endregion

//        #region Course Methods **
//        public async Task<bool> AddCourseAsync(Course course)
//        {
//            courses.Add(course);

//            return await Task.FromResult(true);
//        }

//        public async Task<bool> UpdateCourseAsync(Course course)
//        {
//            var oldCourse = courses.Where((Course arg) => arg.CourseTitle == course.CourseTitle).FirstOrDefault();
//            courses.Remove(oldCourse);
//            courses.Add(course);

//            return await Task.FromResult(true);
//        }

//        public async Task<bool> DeleteCourseAsync(string CourseTitle)
//        {
//            var oldCourse = courses.Where((Course arg) => arg.CourseTitle == CourseTitle).FirstOrDefault();
//            courses.Remove(oldCourse);

//            return await Task.FromResult(true);
//        }

//        public async Task<Course> GetCourseAsync(string CourseTitle)
//        {
//            return await Task.FromResult(courses.FirstOrDefault(s => s.CourseTitle == CourseTitle));
        //}

//        public async Task<IEnumerable<Course>> GetCourseAsync(bool forceRefresh = false)
//        {
//            return await Task.FromResult(courses);
//        }
//        #endregion

//        #region Assessment Methods **
//        public async Task<bool> AddAssessmentAsync(Assessment assessment)
//        {
//            assessments.Add(assessment);

//            return await Task.FromResult(true);
//        }

//        public async Task<bool> UpdateAssessmentAsync(Assessment assessment)
//        {
//            var oldAssessment = assessments.Where((Assessment arg) => arg.AssessmentTitle == assessment.AssessmentTitle).FirstOrDefault();
//            assessments.Remove(oldAssessment);
//            assessments.Add(assessment);

//            return await Task.FromResult(true);
//        }

//        public async Task<bool> DeleteAssessmentAsync(string AssessmentTitle)
//        {
//            var oldAssessment = assessments.Where((Assessment arg) => arg.AssessmentTitle == AssessmentTitle).FirstOrDefault();
//            assessments.Remove(oldAssessment);

//            return await Task.FromResult(true);
//        }

//        public async Task<Assessment> GetAssessmentAsync(string AssessmentTitle)
//        {
//            return await Task.FromResult(assessments.FirstOrDefault(s => s.AssessmentTitle == AssessmentTitle));
//        }

//        public async Task<IEnumerable<Assessment>> GetAssessmentAsync(bool forceRefresh = false)
//        {
//            return await Task.FromResult(assessments);
//        }
//        #endregion
//    }
//}
