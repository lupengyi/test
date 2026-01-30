# SequenceDefinition Validation Strategy

## Schema Validation (Pre-Load)
1. Validate JSON against `docs/sequence-definition.schema.json`.
2. Required fields: `name`, `version`, `station`, `productId`, `processId`, `steps`.
3. Step uniqueness: all `steps[].id` must be unique within the sequence and hooks.
4. Hook steps are optional but must satisfy the same schema as normal steps.

## Semantic Validation (Pre-Run)
1. Plugin discovery: ensure each `step.plugin` exists and is resolvable to a step implementation.
2. Limits: if `limitsRef` is specified, it must resolve via `ILimitsProvider`.
3. Timeout bounds: `timeout` must be > 0 if present.
4. Retry bounds: `maxRetries` must be >= 0; `delay` must be >= 0 when specified.
5. Conditions: `expression` must reference known variables (`variables[]`) or supported context tokens.
6. Station/process/product match: `station.processId` and `processId` must be consistent.

## Versioning
- `version` is a semantic version string, recorded in run snapshots for traceability.
- Any schema changes must bump `version`.
