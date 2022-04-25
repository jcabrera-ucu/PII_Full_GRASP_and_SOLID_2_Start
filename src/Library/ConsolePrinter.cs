using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    // Para éste cambio se utiliza el patrón SRP, ya que se elimina la 
    // responsabilidad de imprimir la receta de la clase Recipe, y se
    // implementa en una clase aparte cuya única responsabilidad es la
    // de imprimir por consola el Recipe.
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.Steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}
