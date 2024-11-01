using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Calculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the application
            this.Close();
        }

        private void workshopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // Establishing variables
            string selectedWorkshop = workshopList.SelectedItem.ToString();
            string selectedCity = locationList.SelectedItem.ToString();
            int costs = 0;

            // Deciding which workshop is selected 
            switch (selectedWorkshop)
                {
                    case "Handling Stress":
                        totalDaysOutputLabel.Text = "3";
                        registrationFeeOutputLabel.Text = "1000";
                        break;
                    case "Time Management":
                        totalDaysOutputLabel.Text = "3";
                        registrationFeeOutputLabel.Text = "800";
                        break;
                    case "Supervision Skills":
                        totalDaysOutputLabel.Text = "3";
                        registrationFeeOutputLabel.Text = "1500";
                        break;
                    case "Negotiation":
                        totalDaysOutputLabel.Text = "5";
                        registrationFeeOutputLabel.Text = "1300";
                        break;
                    case "How to Interview":
                        totalDaysOutputLabel.Text = "1";
                        registrationFeeOutputLabel.Text = "500";
                        break;
                }
            
           // Deciding which city is selected and calculating lodging fee
            switch (selectedCity)
                {
                    case "Austin":
                        lodgingFeeOutputLabel.Text = "150";
                        break;
                    case "Chicago":
                        lodgingFeeOutputLabel.Text = "225";
                        break;
                    case "Dallas":
                        lodgingFeeOutputLabel.Text = "175";
                        break;
                    case "Orlando":
                        lodgingFeeOutputLabel.Text = "300";
                        break;
                    case "Phoenix":
                        lodgingFeeOutputLabel.Text = "175";
                        break;
                    case "Raleigh":
                        lodgingFeeOutputLabel.Text = "150";
                        break;
                }

            // Establishing variables from user selection and converting them to integers
            int days = Convert.ToInt32(totalDaysOutputLabel.Text);
            int registrationFees = Convert.ToInt32(registrationFeeOutputLabel.Text);
            int lodgingFees = Convert.ToInt32(lodgingFeeOutputLabel.Text);

            // Calculating total cost with math on the integers
            costs = (days * lodgingFees) + registrationFees;

            // Updates the total output label from the mathimatical equation
            totalCostOutputLabel.Text = Convert.ToString(costs);
        }
    }
}
