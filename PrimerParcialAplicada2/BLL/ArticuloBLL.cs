using Microsoft.EntityFrameworkCore;
using PrimerParcialAplicada2.DAL;
using PrimerParcialAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PrimerParcialAplicada2.BLL
{
    public class ArticuloBLL
    {
        public static Articulos Buscar(int id)
        {

            Contexto contexto = new Contexto();
            Articulos articulo;

            try
       {

                articulo = contexto.Articulos.Find(id);
            }

            catch (Exception)

            {

             throw;

            }


            finally


            {

                contexto.Dispose();


            }

            return articulo;

        }

        public static bool Guardar(Articulos articulo)


        {


            if (!Existe(articulo.ArtiiculoId))

                return Insertar(articulo);

            else

                return Modificar(articulo);

        }

        private static bool Insertar(Articulos articulos)

        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {

              contexto.Articulos.Add(articulos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)

            {
                throw;
            }
            finally
            {
             contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Articulos articulo)

        {

            bool paso = false;

            Contexto contexto = new Contexto();

            try

            {

                contexto.Entry(articulo).State = EntityState.Modified;



                paso = contexto.SaveChanges() > 0;

            }



            catch (Exception)

            {

                throw;



            }



            finally



            {



                contexto.Dispose();



            }



            return paso;



        }

        public static bool Eliminar(int id)

        {



            bool paso = false;



            Contexto contexto = new Contexto();



            try

            {

                if (!Existe(id))

                {

                    var person = contexto.Articulos.Find(id);



                    if (person != null)

                    {

                        contexto.Articulos.Remove(person);



                        paso = contexto.SaveChanges() > 0;
                    }

                }

            }
            catch (Exception)
            {

                throw;

            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> articulo)
        {
            List<Articulos> lista = new List<Articulos>();
            Contexto db = new Contexto();
            try
            {
                lista = db.Articulos.Where(articulo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();

            }

            return lista;
        }
        public static bool Existe(int id)
        {

            Contexto contexto = new Contexto();

            bool encontrado = false;

            try

            {

                encontrado = contexto.Articulos.Any(p => p.ArtiiculoId == id);

            }

            catch (Exception)



            {

                throw;

            }
            finally
            {



                contexto.Dispose();



            }



            return encontrado;



        }


    }
}

