FROM mcr.microsoft.com/mssql/server:2017-CU18-ubuntu-16.04
ARG SA_PASSWORD
ENV SA_PASSWORD=$SA_PASSWORD
ENV ACCEPT_EULA=Y
COPY entrypoint.sh entrypoint.sh
COPY SqlCmdStartup.sh SqlCmdStartup.sh
COPY SqlCmdScript.sql SqlCmdScript.sql
RUN chmod +x ./SqlCmdStartup.sh
CMD /bin/bash ./entrypoint.sh