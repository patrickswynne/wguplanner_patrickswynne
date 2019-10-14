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
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            //GetNotifications();
        }

        async void GetNotifications()
        {            
            List<Planner> terms = await App.PlannerRepository.GetAllPlannerAsync();
            var distinctTerms = terms.Where(x => x.AssessmentEndDate == DateTime.Now.AddDays(1)).Select(y => y).Distinct().ToList();
        }
    }
}