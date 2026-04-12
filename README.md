# .NET QA Automation Framework (Playwright + BDD)

## 📌 Overview

This project is a QA Automation framework built with **.NET 8**, focused on UI end-to-end testing using **Playwright** and **BDD (Reqnroll)**.

It demonstrates how to design a scalable and maintainable test framework with modern tooling, including:

* BDD approach (Gherkin scenarios)
* Page Object Model
* Dockerized execution
* CI integration
* Allure reporting

---

## 🧱 Tech Stack

* **.NET 8**
* **C#**
* **Playwright**
* **NUnit**
* **Reqnroll (BDD)**
* **Allure Reports**
* **Docker**

---

## 🏗️ Architecture

The project follows a layered structure:

```
/src
  /Pages          → Page Object Model implementation

/Tests
  /BDD
    /Features     → Gherkin scenarios
    /Steps        → Step definitions
    /Hooks        → Test lifecycle management
    /Support      → Shared test state
  /UI             → Legacy NUnit UI tests (migrated to BDD)
```

### Key Concepts

*  BDD approach using Reqnroll with Gherkin scenarios for business-readable tests
*  UI automation built on Microsoft Playwright with reliable browser interaction
*  Page Object Model for clean separation of test logic and UI layer
*  Cross-browser testing capability provided by Playwright
*  Structured test reporting with Allure Reports
*  Screenshot capture on test failure for debugging

---

## 🚀 How to Run Tests

### ▶️ Run locally

```bash
dotnet test
```

---

### 🐳 Run with Docker

```bash
docker-compose up --build
```

---

## 📊 Test Reports (Allure)

After test execution, Allure results are generated.

To serve the report locally:

```bash
allure serve allure-results
```

In CI, reports are published via GitHub Pages.

👉 Latest report:
https://andrewkchn.github.io/dotnet-qa-automation-framework/

---

## ⚙️ CI/CD

The project includes a GitHub Actions workflow that:

* Builds .NET solution
* Executes UI tests in Dockerized environment
* Runs Playwright tests in headless mode
* Collects Allure results as artifacts
* Publishes report to GitHub Pages

## 🚀 Run Tests Manually

You can trigger the test pipeline manually from GitHub Actions:

👉 https://github.com/AndrewKchn/dotnet-qa-automation-framework/actions/workflows/config.yml

Click **"Run workflow"** button on the right side.

---

## 🧪 Example Scenario

```gherkin
Feature: Checkout

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
```
---

## 📈 Future Improvements

* Add Dependency Injection (DI)
* Introduce configuration management (appsettings.json)
* Enable parallel test execution
* Add structured logging
* Improve test data management

---

## 👨‍💻 Author

Andrii

---
