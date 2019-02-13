# 2 Egg Problem

Team 7 - scala implementation

C5 Code challenge #1: code-bowl.io

## Prerequisits

Install Java 8

## Running

Execute the following command

```bash
java -jar 2-egg 1000 777
```

## Source Code

The source code for consideration is found in `src/main/scala/Main.scala`.

## Dev

First install sbt (Scala build tool) for dev.

Make changes to `src/main/scala/Main.scala` and run the following to test.

```bash
sbt -error "run 100 77"
```

## Package

To package the project for submission, a standalone jar file will be built.
This means only java is required to run the application. It also runs faster as it's pre-compiled. This is what's used in the Running section and for submission.

```bash
sbt assembly && mv target/scala-2.12/2-egg-assembly-1.0.jar 2-egg.jar
```

This command will use an assembly plugin to make a self contained jar executable. The move command moves the jar to the top level folder for convenience.
