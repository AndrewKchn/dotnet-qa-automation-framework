Feature: Login
As a user
I want to log into the system
So that I can access the application

@ui @auth @regression  @smoke 
Scenario: User can login with valid credentials
    Given user opens login page
    When user logs in with credentials
        | Username      | Password     |
        | standard_user | secret_sauce |
    Then inventory page is displayed