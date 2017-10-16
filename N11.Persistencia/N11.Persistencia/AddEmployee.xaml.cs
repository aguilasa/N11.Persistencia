using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace N11.Persistencia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmployee : ContentPage
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            var vEmployee = new Employee()
            {
                EmpName = txtEmpName.Text,
                Department = txtDepartment.Text,
                Designation = txtDesign.Text,
                Qualification = txtQualification.Text
            };

            try {
                App.DAUtil.SaveEmployee(vEmployee);
                Navigation.PushAsync(new ManageEmployee());
            } catch (Exception ex) {
                this.DisplayAlert("Aviso", "Erro ao gravar empregado", "Ok");
            }           
            
        }
    }
}