
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using Android.Graphics;
using System.Collections;
using static Android.Views.ViewGroup;
using Syncfusion.SfDataGrid;
using System;

namespace GettingStarted
{
    [Activity(Label = "WithUnBoundCode", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        SfDataGrid grid;
        ViewModel viewModel;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            grid = new SfDataGrid(this);
            viewModel = new ViewModel();
            grid.AllowSorting = true;
            grid.AutoGenerateColumns = false;
            grid.ColumnSizer = ColumnSizer.Star;
            grid.ItemsSource = viewModel.DynamicCollection;
            grid.Columns.Add(new GridTextColumn()
            {
                HeaderText = "Order ID",
                MappingName = "OrderID",
                LineBreakMode = LineBreakMode.WordWrap,
                TextAlignment = Android.Views.GravityFlags.Left,
                HeaderTextAlignment = Android.Views.GravityFlags.Left,
            });

            grid.Columns.Add(new GridTextColumn()
            {
                HeaderText = "Customer ID",
                MappingName = "EmployeeID",
                LineBreakMode = LineBreakMode.WordWrap,
                TextAlignment = Android.Views.GravityFlags.Left,
                HeaderTextAlignment = Android.Views.GravityFlags.Left,
            });

            grid.Columns.Add(new GridTextColumn()
            {
                HeaderText = "First Name",
                MappingName = "FirstName",
                LineBreakMode = LineBreakMode.WordWrap,
                TextAlignment = Android.Views.GravityFlags.Left,
                HeaderTextAlignment = Android.Views.GravityFlags.Left,
            });

            grid.Columns.Add(new GridTextColumn()
            {
                HeaderText = "Last Name",
                MappingName = "LastName",
                LineBreakMode = LineBreakMode.WordWrap,
                TextAlignment = Android.Views.GravityFlags.Left,
                HeaderTextAlignment = Android.Views.GravityFlags.Left,
            });

            SetContentView(grid);
        }
    }
}


