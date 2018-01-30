FROM node

RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app

COPY . .

# Install Oracle Instant Client (required by oracledb package)
# http://www.gilfillan.space/2016/04/24/install-oracle-instant-client-1604/
RUN apt-get update && apt-get install -y gcc libaio1 alien
RUN alien -i ./.oracle-packages/oracle-instantclient12.2-basic-12.2.0.1.0-1.x86_64.rpm
RUN alien -i ./.oracle-packages/oracle-instantclient12.2-devel-12.2.0.1.0-1.x86_64.rpm

RUN npm install

EXPOSE 3000

CMD [ "npm", "start" ]
