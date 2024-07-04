package com.mycompany.calculadora;

import java.util.Scanner;

public class CalculadoraMain {
    public static void main(String[] args) {
        try (Scanner scanner = new Scanner(System.in)) {
            boolean continuar = true;
            
            while (continuar) {
                System.out.println("Seleccione una operación:");
                System.out.println("1. Sumar");
                System.out.println("2. Restar");
                System.out.println("3. Multiplicar");
                System.out.println("4. Dividir");
                System.out.println("5. Salir");
                
                int opcion = scanner.nextInt();
                
                if (opcion == 5) {
                    continuar = false;
                    break;
                }
                
                System.out.println("Ingrese el primer número:");
                int num1 = scanner.nextInt();
                
                System.out.println("Ingrese el segundo número:");
                int num2 = scanner.nextInt();
                
                Calculadora calc = new Calculadora(num1, num2);
                
                switch (opcion) {
                    case 1 -> calc.sumar();
                    case 2 -> calc.restar();
                    case 3 -> calc.multiplicar();
                    case 4 -> calc.dividir();
                    default -> System.out.println("Opción no válida.");
                }
            }
        }
    }
}
