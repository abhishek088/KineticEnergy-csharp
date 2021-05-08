//Author: Group 1: Abhishek Sawant, Konrad Gaerdes, Rupal Pandya

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KineticEnergy
{
    class VM : INotifyPropertyChanged
    {
        const decimal FORMULA_CONSTANT = 0.5m;

        public void CalcKineticEnergy() //Method to calculate kinetic energy
        {
            try
            {
                ErrorMessage = "";

                decimal MassKgInDecimal = decimal.Parse(MassKg);
                decimal VelocityMsInDecimal = decimal.Parse(VelocityMs);

                if (MassKgInDecimal < 0)
                    ErrorMessage = "Mass cannot be a negative value";
                else
                    KineticEnergy = FORMULA_CONSTANT * MassKgInDecimal * VelocityMsInDecimal * VelocityMsInDecimal;
            }
            catch
            {
                ErrorMessage = "Please enter a valid numeric input";
            }
        }

        public void ClearEverything() //Method to clear everything
        {
            MassKg = "0";
            VelocityMs = "0";
            KineticEnergy = 0;
            ErrorMessage = "";
        }

        #region PropertyChanged
        private string massKg = "0";
        public string MassKg
        {
            get { return massKg; }
            set { massKg = value; notifyChange(); }
        }

        private string velocityMs = "0";
        public string VelocityMs
        {
            get { return velocityMs; }
            set { velocityMs = value; notifyChange(); }
        }

        private decimal kineticEnergy = 0;
        public decimal KineticEnergy
        {
            get { return kineticEnergy; }
            set { kineticEnergy = value; notifyChange(); }
        }

        private string errorMessage = "";
        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; notifyChange(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void notifyChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
