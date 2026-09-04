/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package uy.edu.ctcsalto.ejemploliskov;

/**
 *
 * @author Equipo
 */
public class Cuadrado extends Rectangulo {
    
    @Override
    public void setAncho(float ancho) {
        super.setAncho(ancho);
        super.setLado(ancho);
    }

    @Override
    public void setLado(float lado) {
        super.setLado(lado); 
        super.setAncho(lado);
    }
}
