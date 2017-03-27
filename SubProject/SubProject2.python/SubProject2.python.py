import clr
clr.AddReference("App.PCL")
from App.PCL import *

appconfig = AppConfig()

print appconfig.Title