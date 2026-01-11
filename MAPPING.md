# MAPPING.md

This file records all identifier renames performed in the refactor/english-identifiers branch (old_name -> new_name).

Format (Markdown table):
| Old name | New name | File path(s) | Notes |
|---|---|---|---|

This file will be populated incrementally as the automated Roslyn-based renames run across the solution. It is intentionally empty at first to make each subsequent commit append vetted mappings.

Example entries (illustrative):
| btnSalvar_Click | btnSave_Click | MainForm.Designer.cs, MainForm.cs | Renamed control identifier; Text property preserved in .resx (Portuguese) |

Do NOT treat this file as authoritative until the PR review; each mapping is a single-commit atomic rename and is traceable in the commit history.
