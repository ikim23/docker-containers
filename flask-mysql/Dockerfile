# https://github.com/tiangolo/uwsgi-nginx-flask-docker
FROM tiangolo/uwsgi-nginx-flask:python3.6

# install modules
RUN pip install flask-mysql

COPY ./app /app
