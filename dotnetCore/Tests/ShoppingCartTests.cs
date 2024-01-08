using Application;

namespace Tests;

public class ShoppingCartTests
{
    private readonly ShoppingCart _cart;

    public ShoppingCartTests()
    {
        _cart = new ShoppingCart();
    }

    [Fact]
    public void calculate_the_final_price()
    {
        _cart.Add(10);
        
        Assert.Equal(10, _cart.CalculateTotalPrice());
    }

    [Fact]
    public void knows_the_number_of_items()
    {
        _cart.Add(10);

        Assert.Equal(1, _cart.NumberOfProducts());
    }

    [Fact]
    public void may_offer_discounts_when_there_at_least_one_expensive_product()
    {
        _cart.Add(120);

        Assert.True(_cart.HasDiscount());
    }

    [Fact]
    public void does_not_offer_discount_for_cheap_products()
    {
        _cart.Add(10);

        Assert.False(_cart.HasDiscount());
    }
}