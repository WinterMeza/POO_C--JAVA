package com.mycompany.calculadora;

public class Calculadora {
    // Atributos
    private int num1;
    private int num2;

    // Constructor
    public Calculadora(int num1, int num2) {
        this.num1 = num1;
        this.num2 = num2;
    }

    // Métodos
    public void sumar() {
        int suma = num1 + num2;
        System.out.println("Suma: " + suma);
    }

    public void restar() {
        int resta = num1 - num2;
        System.out.println("Resta: " + resta);
    }

    public void multiplicar() {
        int producto = num1 * num2;
        System.out.println("Multiplicación: " + producto);
    }

    public void dividir() {
        if (num2 != 0) {
            double division = (double) num1 / num2;
            System.out.println("División: " + division);
        } else {
            System.out.println("No se puede dividir por cero.");
        }
    }
}
