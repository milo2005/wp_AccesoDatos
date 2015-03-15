using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace AccessData.Models
{
    public class PizzaDAO
    {

        String pathDB = Path.Combine(ApplicationData
            .Current.LocalFolder.Path, "comida.sqlite"
            );

        SQLiteConnection con;

        public PizzaDAO() {
            con = new SQLiteConnection(pathDB);
            con.CreateTable<Pizza>();
        }

        public void insertPizza(Pizza pizza) {
            con.Insert(pizza);
        }

        public void updatePizza(Pizza pizza) {
            con.Update(pizza);
        }

        public void deletePizza(Pizza pizza) {
            con.Delete(pizza);
        }

        public List<Pizza> findAllPizza() {
            List<Pizza> data = con.Table<Pizza>().ToList();
            return data;
        }
        public List<Pizza> findPizzasByNombre(String nombre) {
            List<Pizza> data = con
                .Query<Pizza>("SELECT * FROM Pizza WHERE Nombre LIKE '%"+nombre+"%'");

            return data;
        }





    }
}
