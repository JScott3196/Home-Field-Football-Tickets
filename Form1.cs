//Program: "Home Field Football Tickets"
//Programmer: Joshua Scott
//Purpose: This program is a system to select and purchase tickets for football games at Raymond James Stadium for college football games
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Field_Football_Tickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //this is to make the custom seat selection group and picture box to be visible if custom radio is checked
            //currently not working as intended
            if (studentRadio.Checked)
            {
                customGroup.Visible = false;
                seatPic.Visible = false;
            }
            if (cheapRadio.Checked)
            { 
                customGroup.Visible = false;
                seatPic.Visible = false;
            }
            if (customRadio.Checked)
            {
                customGroup.Visible = true;
                seatPic.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //clean exit
            this.Close();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //constant variables declared
            const double STUDENT_TICKET = 15.00;
            const double FIRST_LEVEL = 50.00;
            const double SECOND_LEVEL = 35.00;
            const double DISCOUNT = .15;

            //other variables
            double ticketCost=0;
            int totalTickets=0;
            double finalCost=0;
            int section=0;
            string row="";

            if (studentRadio.Checked)
            {
                //student ticket choice
                ticketCost = STUDENT_TICKET;
                //display is not working as intended
                sectionDisplay.Text = "STUDENT SECTION";
                rowDisplay.Text = "NO ASSIGNED SEATING";


            }
            if (cheapRadio.Checked)
            {
                //cheapest ticket selection
                //display not yet implemented
                ticketCost = 35.00;
            }
            if (customRadio.Checked)
            {
                //customer seat selection
                //drop down isnt working as intended when displaying/calculating ticket cost
                section = (int)sectionBox.SelectedValue;
                row = (string)rowBox.SelectedValue;

                if (section < 200)
                {
                    ticketCost = FIRST_LEVEL;
                }
                if (section >199)
                {
                    ticketCost = SECOND_LEVEL;
                }

            }
            //saving user input on number of tickets needed
            totalTickets = int.Parse(ticketText.Text);
            //calculating number of tickets
            finalCost = ticketCost * totalTickets;
            //displaying totals
            //section and row not working as intended
            costDisplay.Text = "$" + finalCost;
            sectionDisplay.Text = section.ToString();
            rowDisplay.Text = row;

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //this will be used to print the tickets
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            //this will be used to process payment
        }
    }
}
