@echo off
echo Give focus to the game when the injector starts executing
injector.exe -dll KingdomCoinTrainer.dll -target kingdom.exe -namespace KingdomCoinTrainer -class Mod -method Load
pause