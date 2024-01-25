# Overview

This repository contains a setup for testing the Azure DevOps extensions. It consists of
* A custom Azure DevOps marketplace, where pre-release extensions can be dropped
* A set of pipelines with sample projects that use the pre-release extensions
* A set of projects on SonarQube (peach) and SonarCloud where the analysis results are published

Detailed documentation of the above setups can be found in the [xtranet documentation](https://xtranet-sonarsource.atlassian.net/wiki/spaces/SSG/pages/2298478636/Azure+DevOps+extension+for+SonarQube+SonarCloud).

# Sonar Qube extension testing

* [Azure DevOps pipeline "SonarQube - peach - simple"](https://dev.azure.com/sonar-testing/sonar-scanner-vsts-test/_build?definitionId=3)
* [Peach project "SampleNetSolution"](https://peach.aws-prd.sonarsource.com/dashboard?id=SampleNetSolution)
* [Custom Extension marketplace for testing pre-release extensions](https://marketplace.visualstudio.com/manage/publishers/sonar-testing)
