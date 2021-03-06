﻿// <copyright file="TeamExplorerBaseNavigationLink.cs" company="http://shelvesetcomparer.codeplex.com">Copyright http://shelvesetcomparer.codeplex.com. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.</copyright>
namespace WiredTechSolutions.ShelvesetComparer
{
    using System;
    using Microsoft.TeamFoundation.Controls;

    /// <summary>
    /// Team Explorer base navigation link class.
    /// </summary>
    public class TeamExplorerBaseNavigationLink : TeamExplorerBase, ITeamExplorerNavigationLink
    {
        private bool isEnabled = true;
        private string text;
        private bool isVisible = true;

        public TeamExplorerBaseNavigationLink(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.text = value; 
                this.RaisePropertyChanged("Text");
            }
        }

        public bool IsEnabled
        {
            get
            {
                return this.isEnabled;
            }

            set
            {
                this.isEnabled = value; 
                this.RaisePropertyChanged("IsEnabled");
            }
        }

        public bool IsVisible
        {
            get
            {
                return this.isVisible;
            }

            set
            {
                this.isVisible = value; 
                this.RaisePropertyChanged("IsVisible");
            }
        }

        public virtual void Invalidate()
        {
        }

        public virtual void Execute()
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
