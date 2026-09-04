/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package uy.edu.ctcsalto.ejemploliskov;

/**
 *
 * @author Equipo
 */
public class Rectangulo {

    private float lado;
    private float ancho;
    
    public float getLado() {
        return lado;
    }

    public void setLado(float lado) {
        this.lado = lado;
    }

    public float getAncho() {
        return ancho;
    }

    public void setAncho(float ancho) {
        this.ancho = ancho;
    }
        
    public float calcularArea(){
    return lado * ancho;
    }
}
