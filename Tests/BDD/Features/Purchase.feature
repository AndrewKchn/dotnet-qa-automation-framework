Feature: Checkout
As a user
I want to complete a purchase
So that I can buy products

@ui @checkout @e2e
Scenario: User can complete purchase successfully
    Given user is logged in
    When user adds backpack to cart
    And user opens cart
    When user proceeds to checkout    
    And user fills checkout information:
        | FirstName | LastName | Zip   |
        | John      | Doe      | 12345 |
    And user finishes purchase
    Then order confirmation is shown