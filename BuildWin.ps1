Write-Host "Beginning project build for Linux."
Start-Process -FilePath "C:/Program Files/Unity/Hub/Editor/2020.3.13f1/Editor/Unity.exe" -ArgumentList "-quit", "-batchmode", "-logfile build.log", "-executeMethod MakeBuild.Windows"
Write-Host "Build has finished. Check build.log for errors."