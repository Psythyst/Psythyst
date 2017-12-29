mkdir -p ./Publish

docker run --rm -it psythyst/psythyst:latest cat /Psythyst/Publish/Psythyst.dll > ./Publish/Psythyst.dll
docker run --rm -it psythyst/psythyst:latest cat /Psythyst/Publish/Psythyst.deps.json > ./Publish/Psythyst.deps.json
docker run --rm -it psythyst/psythyst:latest cat /Psythyst/Publish/Psythyst.pdb > ./Publish/Psythyst.pdb