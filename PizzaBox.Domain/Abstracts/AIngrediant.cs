
namespace PizzaBox.Domain.Abstracts
  

{
  public abstract class AIngrediant : AModels
  {
  public string name{get;set;}
  public double price{get; protected set;}
  public bool vegan{get; protected set;}

  public bool veget{get; protected set;}

  }

}