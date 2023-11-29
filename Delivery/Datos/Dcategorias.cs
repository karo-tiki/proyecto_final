﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Delivery.Modelo;

namespace Delivery.Datos
  {
  public class Dcategorias
    {
    public ObservableCollection<Mcategorias> Mostrarcategorias()
      {
      return new ObservableCollection<Mcategorias>()
        {
        new Mcategorias()
          {
          categoria="Infantil",
          icono="https://i.ibb.co/dLjhKHc/burguer.png",
          Textcolor="#2F394B",
          Color1="#ffffff",
           Color2="#ffffff",
           Select=false
          },
          new Mcategorias()
          {
          categoria="Adulto",
          icono="https://i.ibb.co/HCwvTn8/rosquilla.png",
          Textcolor="#2F394B",
            Color1="#ffffff",
           Color2="#ffffff",
            Select=false
          },
          new Mcategorias()
          {
          categoria="Bebidas",
          icono="https://i.ibb.co/dLjhKHc/burguer.png",
          Textcolor="#2F394B",
          Color1="#ffffff",
           Color2="#ffffff",
           Select=false
          },

        };
      }
    }
  }