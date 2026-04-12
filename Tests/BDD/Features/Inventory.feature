Feature: Inventory management
As a user
I want to manage items in my cart
So that I can prepare for checkout

Background:
    Given user is logged in

@ui @inventory @regression 
Scenario: User can add item to cart
    When user adds backpack to cart
    Then cart item count is 1

@ui @inventory @regression
Scenario: User can add multiple items to cart
    When user adds backpack to cart
    And user adds bike light to cart
    Then cart item count is 2

@ui @inventory @regression
Scenario: User can remove item from cart
    When user adds backpack to cart
    And user adds bike light to cart
    And user removes backpack from cart
    Then cart item count is 2