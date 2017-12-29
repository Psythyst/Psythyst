mkdir -p ./Publish

# TODO: Replace all those docker runs... X_X

docker run --rm -it psythyst/psythyst:latest cat /Psythyst/Publish/Psythyst.dll > ./Publish/Psythyst.dll
docker run --rm -it psythyst/psythyst:latest cat /Psythyst/Publish/Psythyst.deps.json > ./Publish/Psythyst.deps.json
docker run --rm -it psythyst/psythyst:latest cat /Psythyst/Publish/Psythyst.pdb > ./Publish/Psythyst.pdb