﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StuffshopPOS.Data;
using StuffshopPOS.Beans;

namespace StuffshopPOS
{
    public partial class Report_Viewer : Form
    {

        private string date1 = "none";
        private string date2 = "none";
        private string customer = "none";
        private int valuecontainer;
        

        public Report_Viewer()
        {
           
            DateDialog start = new DateDialog("Enter Start Date");
            start.ShowDialog();
            date1 = start.dateselected;
            DateDialog end = new DateDialog("Enter End Date");
            end.ShowDialog();
            date2 = end.dateselected;
            CustomerSelectDialog custtt = new CustomerSelectDialog("Please Select Customer");
            custtt.ShowDialog();
            customer = custtt.custselected;
            
            InitializeComponent();
            GPData.ReportData(date1,date2,customer);
        }

        private void Report_Viewer_Load(object sender, EventArgs e)
        {
            ReportView rv = new ReportView();
            ReportSet ds = new ReportSet();
            foreach (ReportContainerClass rc in GPData.reportlist)
            {
                if (rc.soptype == 4)
                {
                    valuecontainer = (rc.quantity - (rc.quantity * 2));
                }
                else
                {
                    valuecontainer = rc.quantity;
                }
                DataRow cRow = ds.ReportViewer.NewRow();
                cRow["SOPNUMBER"] = rc.sopnumber;
                cRow["ITEMNUMBER"] = rc.itemnumber;
                cRow["ITEMDESCRIPTION"] = rc.itemDescription;
                cRow["CUSTOMERNAME"] = rc.custname;
                cRow["QUANTITY"] = valuecontainer;
                cRow["DOCDATE"] = rc.docdate;
                cRow["PRICE"] = rc.price;
                ds.ReportViewer.Rows.Add(cRow);

            }
            rv.DataDefinition.FormulaFields["startDate"].Text = "\"" + date1 + "\"";
            rv.DataDefinition.FormulaFields["End Date"].Text = "\"" + date2 + "\"";
            rv.DataDefinition.FormulaFields["Customer"].Text = "\"" + customer + "\"";
            rv.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rv;
            crystalReportViewer1.Refresh();

        }

        private void Report_Viewer_Leave(object sender, EventArgs e)
        {

        }

    }
}
