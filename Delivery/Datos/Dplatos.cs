using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Delivery.Modelo;

namespace Delivery.Datos
  {
  public class Dplatos
    {
    public  ObservableCollection<Mplatos> Listarplatos()
      {
      return new ObservableCollection<Mplatos>()
        {
        new Mplatos()
          {
          descripcion="Torta de chocolate",
          precio="$90.45",
          icono="https://i.ibb.co/VqGfxv7/torta-cho.png",
         
          },
         new Mplatos()
          {
          descripcion="Panetón",
          precio="$84.45",
          icono="https://i.ibb.co/nBfPzY0/paneton.png",
          
          },
          new Mplatos()
          {
          descripcion="Tres Leches Lúçuma",
          precio="$23.45",
          icono="https://i.ibb.co/vs5mxvM/torta-ch.png"

          },
          new Mplatos()
          {
          descripcion="Torta de Vainilla",
          precio="$58.99",
          icono="https://i.ibb.co/8xkJT5x/torta-va.png"

          },
           new Mplatos()
          {
          descripcion="Torta de Cumpleaños",
          precio="$39.30",
          icono="https://i.ibb.co/hs8hDkg/torta-di.png"

          },
            new Mplatos()
          {
          descripcion="Torta Helada",
          precio="$56.15",
          icono="https://i.ibb.co/k6rXdMx/torta-c.png"

          }


        };
      }
    }
  }
