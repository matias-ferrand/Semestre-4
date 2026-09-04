/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package uy.edu.ctcsalto.ejemploliskov;

import java.util.HashSet;

/**
 *
 * @author Equipo
 */
public class EjemploLiskov {

    public static void main(String[] args) {
        System.out.println("Hola mundo!");
        Rectangulo objRl = new Rectangulo();
        testRectangulo(objRl);
        
        Cuadrado objCl = new Cuadrado();
        testRectangulo(objCl);
    }
    
    public static void testRectangulo(Rectangulo rec)
    {
        rec.setAncho(50);
        rec.setLado(100);
        System.out.println("Area esperada es 5000, area calculada es: " + rec.calcularArea());
        
    }
}
