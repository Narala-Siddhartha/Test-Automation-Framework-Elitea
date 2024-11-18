Feature: Login Functionality
  As a user, I want to be able to log in to the website to access my account.

  Scenario Outline: Login with different sets of credentials
    Given I am on the login page
    When I enter the username '<username>'
    And I enter the password '<password>'
    And I click on the login button
    Then I should be redirected to '<expected_url>' based on the credentials

    Examples:
      | username             | password     | expected_url                                  |
      | standard_user        | secret_sauce | https://www.saucedemo.com/inventory.html      |
      | locked_out_user      | secret_sauce | https://www.saucedemo.com                     |
      | problem_user         | secret_sauce | https://www.saucedemo.com/inventory.html      |
      | performance_glitch_user | secret_sauce | https://www.saucedemo.com/inventory.html      |
      | error_user           | secret_sauce | https://www.saucedemo.com                     |
      | visual_user          | secret_sauce | https://www.saucedemo.com/inventory.html      |
      | standard_user        | wrong_pass   | https://www.saucedemo.com                     |
      | invalid_user         | secret_sauce | https://www.saucedemo.com                     |