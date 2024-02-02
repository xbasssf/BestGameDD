using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BestGameDD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private Wizard selectedWizard;
        private Warrior selectedWarrior;
        private void UserComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)UserComboBox.SelectedItem;
            string selectedClass = selectedItem.Content.ToString();
           
            switch (selectedClass)
            {
                case "Wizard":
                    Wizard wizard = new Wizard();
                    StrengthBaseLabel.Content = wizard.Strength;
                    DexterityBaseLabel.Content = wizard.Dexterity;
                    IntelligenceBaseLabel.Content = wizard.Intelligence;
                    VitalityBaseLabel.Content = wizard.Vitality;
                    break;
                case "Warrior":
                    Warrior warrior = new Warrior();
                    StrengthBaseLabel.Content = warrior.Strength;
                    DexterityBaseLabel.Content = warrior.Dexterity;
                    IntelligenceBaseLabel.Content = warrior.Intelligence;
                    VitalityBaseLabel.Content = warrior.Vitality;
                    break;
            }
        }

        //private void UpdateLabels()
        //{
        //    StrengthBaseLabel.Content = selectedWizard.Strength;
        //    StrengthNowLabel.Content = selectedWizard.Strength;

        //    DexterityBaseLabel.Content = selectedWizard.Dexterity;
        //    DexterityNowLabel.Content = selectedWizard.Dexterity;

        //    IntelligenceNowLabel.Content = selectedWizard.Intelligence;
        //    IntelligenceBaseLabel.Content = selectedWizard.Intelligence;

        //    VitalityNowLabel.Content = selectedWizard.Vitality;
        //    VitalityBaseLabel.Content = selectedWizard.Vitality;
           
        //}
    }
}
