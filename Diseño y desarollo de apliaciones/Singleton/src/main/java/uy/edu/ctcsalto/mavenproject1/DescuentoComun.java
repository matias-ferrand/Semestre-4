/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package uy.edu.ctcsalto.mavenproject1;

/**
 *
 * @author Equipo
 */
public class DescuentoComun implements ITipoDescuento {

    @Override
    public double CalcularDescuento(double monto) {
        if (monto > 3000){
            return monto * 0.05;
        }else if (monto > 1000){
            return monto * 0.03;
        }
        return 0;
    }
    
}
