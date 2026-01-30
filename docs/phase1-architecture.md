# Phase 1 Architecture Overview

## Module Responsibilities
- Contracts: Pure models, interfaces, enums, and error contracts with no implementation dependencies.
- Core: Cross-cutting infrastructure (logging adapters, Result<T>, retry/timeout helpers, error codes, run directory conventions, audit).
- Libraries: Configuration loading/validation, limits engine, and sequence schema validation.
- Instruments: Communication abstractions, base instrument behaviors, and fake instruments for tests.
- InstrumentManager: Instrument lifecycle management, leasing, and IO logging.
- TestSteps: Step plugin contracts and standard step library with capability-based binding.
- Automation: Sequence/flow execution engine with hooks, retry, and concurrency support.
- Tester: Orchestration of configs, sequences, results, and MES integration.
- Supervisor: UI shell (Console first, then WPF) that subscribes to events only.

## Directory Tree (Phase 1)
```
./
├── README.md
├── docs
│   ├── phase1-architecture.md
│   ├── sequence-definition.schema.json
│   └── sequence-validation.md
└── src
    └── Contracts
        ├── Contracts.csproj
        ├── Interfaces
        │   ├── IClock.cs
        │   ├── IConfigProvider.cs
        │   ├── IInstrument.cs
        │   ├── IInstrumentManager.cs
        │   ├── ILimitsProvider.cs
        │   ├── ILog.cs
        │   ├── IMesClient.cs
        │   ├── IResultStore.cs
        │   ├── ISequenceRunner.cs
        │   └── ITestStep.cs
        └── Models
            ├── Identifiers.cs
            ├── Instruments.cs
            ├── Limits.cs
            ├── Results.cs
            └── SequenceDefinition.cs
```
