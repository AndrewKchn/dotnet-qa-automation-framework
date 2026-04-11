Feature: Cart

Scenario: User adds item to cart
    Given user is logged in
    When user adds backpack to cart
    Then cart should contain 1 item