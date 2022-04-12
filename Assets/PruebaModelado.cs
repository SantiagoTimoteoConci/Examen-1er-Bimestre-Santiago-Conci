using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Los nombre de tres productos
//Los precios de cada producto
//La cantidad de unidades deseada de cada producto


//Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad
//de unidades del mismo supera las 3. 

//El programa debe devolver un mensaje de error descriptivo si el precio del producto
//o la cantidad de unidades son menores a 1.

//El programa debe devolver el total de la compra de los tres productos mostrando un
//mensaje que incluya el monto total sin descuento, el monto de los descuentos aplicados
//y el total con los descuentos aplicados.

public class PruebaModelado : MonoBehaviour
{
    public string Producto1;
    public string Producto2;
    public string Producto3;
    public float PrecioProducto1;
    public float PrecioProducto2;
    public float PrecioProducto3;
    public float CantidadProducto1;
    public float CantidadProducto2;
    public float CantidadProducto3;
     float DescuentoProducto1 = 0;
     float DescuentoProducto2 = 0;
     float DescuentoProducto3 = 0;

    void Start()
    {

        //punto numero 1
        if (CantidadProducto1 >= 3)
        {
            DescuentoProducto1 = CantidadProducto1 * PrecioProducto1 * 0.2f;
        }
        if (CantidadProducto2 >= 3)
        {
            DescuentoProducto2 = CantidadProducto2 * PrecioProducto2 * 0.2f;
        }
        if (CantidadProducto3 >= 3)
        {
            DescuentoProducto3 = CantidadProducto3 * PrecioProducto3 * 0.2f;
        }

        //punto numero 2
        if (CantidadProducto1 < 1)
        {
            Debug.Log("error con la cantidad de" + Producto1);
        }
        if (CantidadProducto2 < 1)
        {
            Debug.Log("error con la cantidad de" + Producto2);
        }
        if (CantidadProducto3 < 1)
        {
            Debug.Log("error con la cantidad de" + Producto3);
        }


        if (PrecioProducto1 < 1)
        {
            Debug.Log("error con el precio de" + Producto1);
        }
        if (PrecioProducto2 < 1)
        {
            Debug.Log("error con el precio de" + Producto2);
        }
        if (PrecioProducto3 < 1)
        {
            Debug.Log("error con el precio de" + Producto3);
        }

        //punto numero 3

        Debug.Log("El valor total sin descuentos es:" + CantidadProducto1 * PrecioProducto1 + CantidadProducto2 * PrecioProducto2 + CantidadProducto3 * PrecioProducto3 + ", los descuentos aplicados fueron" + (CantidadProducto1 * PrecioProducto1 - DescuentoProducto1) + (CantidadProducto2 * PrecioProducto2 - DescuentoProducto2) + (CantidadProducto3 * PrecioProducto3 - DescuentoProducto3) + "el total es:" + DescuentoProducto1 + DescuentoProducto2 + DescuentoProducto3);
        



    }

   
    void Update()
    {
        
    }
}
