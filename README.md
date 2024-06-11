This project uses layered 2D perlin noise to create mountains and terrain. I wanted to try to make Terrain heightmap errosion with this as well.

Currently, this all runs on the CPU, but fully functions otherwise.

Next steps for this project:
- Move noise generation to GPU
- implement Terrain smoothing (To make high points and low points eg. A mountain on an island)
- Implement GPU Erosion

The biggest part is perfecting the erosion for the mountains. Currently, this is not implemented. I plan to use HLSL to go index by index on the 2D heightmap array and simulate rain flow pulling matter and depositing matter.
