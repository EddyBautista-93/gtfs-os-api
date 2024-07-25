# GTFS Open Source API

### todo
- [x] Set up and configure ef db context
- [x] Create SQLite DB
- [x] Create Post endpoint to upload routes file (rest of the gtfs files to come)
- [x] Create Get endpoint for route
- [ ] Add validation api to prevent malicious attacks on file upload
- [ ] Create Unit test for data validation.
- [ ] Convert fileupload endpoint to do all files
- [ ] Add the logic to save old data in like a last gtfs data table and add the new set.

## Note
After some thought I think using IFormCollection will be better so that 
we can do a bulk upload of all files and use a service to add all of the data.
Whenever a agency creates a new set of files they can upload it. 