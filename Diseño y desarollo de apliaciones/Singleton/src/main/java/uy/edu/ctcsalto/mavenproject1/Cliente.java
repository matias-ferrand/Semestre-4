/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package uy.edu.ctcsalto.mavenproject1;

/**
 *
 * @author Equipo
 */
public class Cliente {
    
    private int numero;
    private String nombre;
    private String apellido;
    private ITipoDescuento tipoDescuento;
    
    
    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public ITipoDescuento getTipoDescuento() {
        return tipoDescuento;
    }

    public void setTipoDescuento(ITipoDescuento tipoDescuento) {
        this.tipoDescuento = tipoDescuento;
    }


            
    public Cliente(){};
}


