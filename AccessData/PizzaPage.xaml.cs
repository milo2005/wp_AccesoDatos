using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AccessData.Models;

namespace AccessData
{
    public partial class PizzaPage : PhoneApplicationPage
    {
        PizzaDAO pizzaDAO;

        public PizzaPage()
        {
            InitializeComponent();

            pizzaDAO = new PizzaDAO();
        }

        private void savePizza(object sender, RoutedEventArgs e)
        {
            var pizza = LayoutRoot.Resources["pizza"] as Pizza;
            pizzaDAO.insertPizza(pizza);
            loadLastPizza();
        }
        
        public void loadLastPizza() {
            List<Pizza> pizzaList = pizzaDAO.findAllPizza();
            var pizza = pizzaList.ElementAt<Pizza>(pizzaList.Count()-1);

            lNombre.Text = pizza.Nombre;
            lTamanio.Text = ""+pizza.Tamanio;



        }
    }
}