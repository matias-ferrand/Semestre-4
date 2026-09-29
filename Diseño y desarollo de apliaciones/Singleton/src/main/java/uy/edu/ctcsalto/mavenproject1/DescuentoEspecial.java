/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package uy.edu.ctcsalto.mavenproject1;

/**
 *
 * @author Equipo
 */
public class DescuentoEspecial implements ITipoDescuento {

    @Override
    public double CalcularDescuento(double monto) {
        return monto * 0.1;
    }
    
}
