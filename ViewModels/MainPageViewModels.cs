﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingSample.ViewModels
{
    public class MainPageViewModels
    {
        public MainPageViewModels()
        {
            for (int i = 0; i < 100; i++)
            {
                var item = new Models.TodoItem()
                {
                    Title = string.Format("Task Title{0}", i)
                };
                this.Items.Add(item);
            }
        }
        public ObservableCollection<Models.TodoItem> Items
        { get; set; }
                = new ObservableCollection<Models.TodoItem>();
    }
}
