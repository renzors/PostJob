
SET JOB_FOLDER="%WEBROOT_PATH%\App_Data\jobs\continuous\PostJob"
IF EXIST %JOB_FOLDER% (
  rd /S /q %JOB_FOLDER%
)
mkdir %JOB_FOLDER%
xcopy Job %JOB_FOLDER% /E /C