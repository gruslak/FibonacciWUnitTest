pipeline{
  agent any
  stages{
    stage('checkout data'){
      steps{
        git 'https://github.com/gruslak/FibonacciWUnitTest.git'
      }
    }
    stage('restore NuGet'){
      steps{
        bat '"C:/tools/nuget.exe" restore Fibonacci.sln'
      }
    }
    stage('build sln'){
      steps{
        bat "\"${tool 'MSBuild'}/MSBuild.exe\" Fibonacci.sln /p:Configuration=Debug /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
      }
    }
    stage('unit test'){
      steps{
        bat '"C:/Program Files (x86)/Microsoft Visual Studio/2017/Enterprise/Common7/IDE/MSTest.exe" /resultsfile:"Results.trx" /testcontainer:"Fibonacci.Test/bin/Debug/Fibonacci.Test.dll"
      }
    }
  }
}
