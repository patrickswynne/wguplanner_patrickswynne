﻿using System;
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
    public partial class AssessmentEditPage : ContentPage
    {
        private Planner viewModel;

        public AssessmentEditPage(Planner assessment)
        {
            InitializeComponent();

            BindingContext = this.viewModel = assessment;

            LoadCourseList();
        }
        async void LoadCourseList()
        {
            List<Planner> courses = await App.PlannerRepository.GetAllPlannerAsync();
            var distinctCourses = courses.Where(x => x.CourseTitle != null).Select(y => y.CourseTitle).Distinct().ToList();
            CourseTitlePicker.ItemsSource = distinctCourses;

            CourseTitlePicker.SelectedItem = this.viewModel.CourseTitle;
            AssessmentType.SelectedItem = this.viewModel.AssessmentType;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            this.viewModel.AssessmentId = CourseTitlePicker.SelectedItem.ToString() + AssessmentType.SelectedItem;

            //check that this assessment type + course does not exist already
            List<Planner> assessments = await App.PlannerRepository.GetAllPlannerAsync();
            var countAssessments = assessments.Where(x => x.AssessmentId == this.viewModel.AssessmentId).Count();

            if (countAssessments == 0)
            {
                this.viewModel.AssessmentType = AssessmentType.SelectedItem.ToString();
                this.viewModel.CourseTitle = CourseTitlePicker.SelectedItem.ToString();
                await App.PlannerRepository.AddNewAssessmentAsync(this.viewModel);
                await Navigation.PopModalAsync();
            }
            else
            {
                var result = await DisplayAlert("Message", "Only 1 objective and 1 performance assessment may be created for each course.", null, "OK");
            }
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void Delete_Clicked(object sender, EventArgs e)
        {
            await App.PlannerRepository.DeleteAssessmentAsync(this.viewModel.AssessmentTitle);
            await Navigation.PopModalAsync();
        }
    }
}