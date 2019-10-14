using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WGUPlanner.Models;
using SQLite;


namespace WGUPlanner
{
    public class PlannerRepository
    {
        SQLiteAsyncConnection conn;
        public string StatusMessage { get; set; }
        public PlannerRepository(string dbPath)
        {
            conn = new SQLiteAsyncConnection(dbPath);
            conn.CreateTableAsync<Planner>().Wait();
        }
        public async Task AddNewTermAsync(Planner planner)
        {

            int result = 0;
            try
            {
                result = await conn.InsertAsync(planner);

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, planner.TermTitle);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", planner.TermTitle, ex.Message);
            }
        }
        public async Task UpdateTermAsync(Planner planner)
        {
            await conn.UpdateAsync(planner);
        }
        public async Task<List<Planner>> GetAllPlannerAsync()
        {
            try
            {
                return await conn.Table<Planner>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Planner>();
        }
        public async Task AddNewCourseAsync(Planner planner)
        {

            int result = 0;
            try
            {
                result = await conn.InsertAsync(planner);

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, planner.CourseTitle);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", planner.CourseTitle, ex.Message);
            }
        }
        public async Task UpdateCourseAsync(Planner planner)
        {
            await conn.UpdateAsync(planner);
        }
        public async Task AddNewAssessmentAsync(Planner planner)
        {

            int result = 0;
            try
            {
                result = await conn.InsertAsync(planner);

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, planner.AssessmentTitle);
            }
            catch (Exception ex)
            {
                //
            }
        }
        public async Task UpdateAssessmentAsync(Planner planner)
        {
            await conn.UpdateAsync(planner);
        }
        public async Task<bool> DeleteTermAsync(string termTitle)
        {
            await conn.Table<Planner>().DeleteAsync(x => x.TermTitle == termTitle);
            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteCourseAsync(string courseTitle)
        {
            await conn.Table<Planner>().DeleteAsync(x => x.CourseTitle == courseTitle);
            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteAssessmentAsync(string assessmentTitle)
        {
            await conn.Table<Planner>().DeleteAsync(x => x.AssessmentTitle == assessmentTitle);
            return await Task.FromResult(true);
        }
    }
}
