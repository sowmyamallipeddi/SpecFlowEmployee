Feature: EmployeeDetails
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectEmployee/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Checking if Employee Data is present or not
	Given the Department is "Testing"
	When Department is present in the table
	Then the following Details are retrieved
	| EmployeeID | FirstName | LastName   | Department
	| 1          | Sowmya    | Mallipeddi | Testing
	| 2          | John      | Smith      | Testing
	| 3          | Bob       | Jones      |Testing


@mytag
Scenario: Getting the Employee Details 
 Given the following employees are present in the table
 | EmployeeID | FirstName | LastName | Department
 | 4          | Harry     | Potter   | DevOps
 | 5          | James     | Bond     | BA
 | 6          | Josh      | Lee      |Developer
 When I apply SpecFlow.Assit
 Then the following Details are shown
 | EmployeeID | FirstName | LastName | Department
 | 5          | James     | Bond     | BA
 | 6          | Josh      | Lee      |Developer
 | 4          | Harry     | Potter   | DevOps

	