# Testing of .NET Binding Redirect Feature
This project is aimed at testing the functionality of the Binding Redirect feature in .NET framework. The binding redirect feature allows developers to redirect assembly version references from one version to another in case of compatibility issues or upgrading to a new version. In this project we try to use assembly resolver to emulate config file.

## Prerequisites
* .NET Framework 4.0 or later.
* JetBrains Rider.

## Installation
* Clone this repository to your local machine using git clone https://github.com/mfilipov/testing-binding-redirect.git.
* Open the solution file (.sln) in Rider.
* Build the solution.

## Usage
* Run the BindingRedirectorByVersion project to observe how redirection by version works.
* Run the BindingRedirectorByVersionAndToken project to observe how redirection by version and public token doesn't works.

## Contributing
If you want to contribute to this project, please follow these steps:
* Fork this repository.
* Create a new branch with a descriptive name (e.g. feature/<feature-name>).
* Make your changes in the new branch.
* Commit your changes and push to the branch.
* Open a pull request from your branch to the master branch of this repository.

## License
This project is licensed under the Apache 2.0 License. Please see the LICENSE file for details.