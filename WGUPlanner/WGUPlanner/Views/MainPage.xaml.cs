using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WGUPlanner.Models;
using Xamarin.Forms;

namespace WGUPlanner.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            CreatePlannerData();
        }

        async void CreatePlannerData()
        {
            // Term
            Planner planner = new Planner();            
            planner.TermTitle = "Spring 2099";
            planner.TermNotification = true;            
            planner.TermStartDate = DateTime.Parse("03/01/2019");
            planner.TermEndDate = DateTime.Parse("09/01/2019");
            // Course
            //planner = new Planner();
            planner.TermTitle = "Spring 2099";
            planner.CourseTitle = "Programming 101";
            planner.CourseStatus = "Plan To Take";
            planner.CourseStartDate = DateTime.Parse("03/01/2019");
            planner.CourseEndDate = DateTime.Parse("09/01/2019");
            planner.CourseNotification = true;
            planner.CourseNotes = "nothing yet";
            planner.CourseInstructorName = "Patrick Wynne";
            planner.CourseInstructorEmail = "pwynne1@wgu.edu";
            planner.CourseInstructorPhone = "972-748-3218";
            // Assessments
            //planner = new Planner();            
            planner.CourseTitle = "Programming 101";
            planner.AssessmentTitle = "Programming Performance A.";
            planner.AssessmentNotification = true;
            planner.AssessmentType = "performance";
            planner.AssessmentId = "Programming 101performance";
            planner.AssessmentStartDate = DateTime.Parse("03/01/2019");
            planner.AssessmentEndDate = DateTime.Parse("09/01/2019");
            await App.PlannerRepository.AddNewAssessmentAsync(planner);


            // Term
            planner = new Planner();
            planner.TermTitle = "Spring 2099";
            planner.TermNotification = true;
            planner.TermStartDate = DateTime.Parse("03/01/2019");
            planner.TermEndDate = DateTime.Parse("09/01/2019");
            // Course
            //planner = new Planner();
            planner.TermTitle = "Spring 2099";
            planner.CourseTitle = "Programming 101";
            planner.CourseStatus = "Plan To Take";
            planner.CourseStartDate = DateTime.Parse("03/01/2019");
            planner.CourseEndDate = DateTime.Parse("09/01/2019");
            planner.CourseNotification = true;
            planner.CourseNotes = "nothing yet";
            planner.CourseInstructorName = "Patrick Wynne";
            planner.CourseInstructorEmail = "pwynne1@wgu.edu";
            planner.CourseInstructorPhone = "972-748-3218";
            // Assessments
            planner.CourseTitle = "Programming 101";
            planner.AssessmentTitle = "Programming Objective A.";
            planner.AssessmentNotification = true;
            planner.AssessmentType = "objective";
            planner.AssessmentId = "Programming 101objective";
            planner.AssessmentStartDate = DateTime.Parse("03/01/2019");
            planner.AssessmentEndDate = DateTime.Parse("09/01/2019");
            await App.PlannerRepository.AddNewAssessmentAsync(planner);
        }
    }
}