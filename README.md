# KakuroHelper
C# Kakuro Helper and Solver

# Purpose
This project creates a small tool intended to support you solving Kakuro puzzles (See https://en.wikipedia.org/wiki/Kakuro for details). 
The tool is entirely written in C# using Windows Forms. Initially only a small helper to generate the possible sequences for given number and length is included.
Later more sophisticated tools to solve small parts of puzzles or complete puzzles might be added.

# Version
Current version is V0.0.2, see Tags for version history

# Tooling
Visual Studio 2013 or newer is required to build the software. I might provide executables for download in the future. If you are interested, let me know.

# Status
## Implemented features
* Three independet groups to calculate all possible integer sequences for given number and length of field
* Possibility to state that certain numbers must be included
* Instant update of sequences on change of relevant parameter

## Planned features
* Connect two groups (containg row and column from puzzle) to show all possible integers for intersection
* Possibility to exclude numbers for above mentioned intersection to account for numbers already present in other cells
* Second tool to solve subsets of puzzles or complete puzzles entered manually by the user
* Mult-Language support (English / German / ...)

# Contribute
Feel free to fork or make feature proposals
